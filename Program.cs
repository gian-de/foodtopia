using System.Text;
using System.Threading.RateLimiting;
using foodtopia.Database;
using foodtopia.Interfaces;
using foodtopia.Interfaces.Admin;
using foodtopia.Models;
using foodtopia.Services;
using foodtopia.Services.Admin;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddIdentity<AppUser, IdentityRole<Guid>>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8;

    options.SignIn.RequireConfirmedEmail = true;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme =
    options.DefaultChallengeScheme =
    options.DefaultForbidScheme =
    options.DefaultScheme =
    options.DefaultSignInScheme =
    options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
    {
        var signingKey = Environment.GetEnvironmentVariable("JWT_SIGNING_KEY");
        if (string.IsNullOrEmpty(signingKey)) throw new Exception("JWT_SIGNING_KEY env variable in not set.");

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidIssuer = Environment.GetEnvironmentVariable("") ?? builder.Configuration["JWT:Issuer"],
            ValidAudience = Environment.GetEnvironmentVariable("") ?? builder.Configuration["JWT:Audience"],
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey))
        };
    }
);

builder.Services.AddScoped<ISeniorAdminService, SeniorAdminService>();
builder.Services.AddScoped<IModeratorService, ModeratorService>();

builder.Services.AddScoped<AccountService>();
builder.Services.AddScoped<IJwtTokenService, JwtTokenService>();
builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IIngredientService, IngredientService>();
builder.Services.AddScoped<IHeartedRecipeService, HeartedRecipeService>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<ILeaderboardService, LeaderboardService>();
builder.Services.AddScoped<IPlaylistService, PlaylistService>();

builder.Services.AddHostedService<GuestRecipeCronJobDeleteService>();

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        var baseUrl = Environment.GetEnvironmentVariable("BASE_URL") ?? "http://localhost:8000";

        policy.WithOrigins(baseUrl, "http://localhost:3000", "http://localhost:5001")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddRateLimiter(options =>
{
    options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(context =>
    {
        var ipAddress = context.Connection.RemoteIpAddress?.ToString() ?? "unknown";

        return RateLimitPartition.GetFixedWindowLimiter(ipAddress, _ => new FixedWindowRateLimiterOptions
        {
            PermitLimit = 10,
            Window = TimeSpan.FromSeconds(15),
            QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
            QueueLimit = 0
        });
    });
    options.RejectionStatusCode = 429;
});

builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("fixed-limiter-strict", limiterOptions =>
    {
        limiterOptions.PermitLimit = 6;
        limiterOptions.Window = TimeSpan.FromSeconds(30);
        limiterOptions.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        limiterOptions.QueueLimit = 0;
    });
    options.RejectionStatusCode = 429;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var userManager = services.GetRequiredService<UserManager<AppUser>>();
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

    try
    {
        // important - apply migrations before seeding 'AppDbSeeder.cs' file aka 'AppDbSeeder.SeedAsync' func a few lines below, so the 'owner' account/role doesn't default to 'user' - (if the other way around, the line 31 in 'AppDbSeeder.cs' returns an empty list since the '../Seeds/RoleSeed.cs' hasn't been called upon in the 'AppDbContext.cs' file 'OnModelCreating' line 134)
        var db = services.GetRequiredService<AppDbContext>();
        await db.Database.MigrateAsync();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Seeding failed. Check 'Program.cs'");
    }


    await AppDbSeeder.SeedAsync(userManager, roleManager);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "OpenAPI V1");
    });
}

app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseCors();

app.UseAuthentication();
app.UseRateLimiter();
app.UseAuthorization();

app.MapControllers();

app.Run();
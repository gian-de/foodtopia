using foodtopia.Database;
using foodtopia.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services
{
    public class GuestRecipeCronJobDeleteService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<GuestRecipeCronJobDeleteService> _logger;

        private int _iterationCount = 0;

        public GuestRecipeCronJobDeleteService(IServiceProvider serviceProvider, ILogger<GuestRecipeCronJobDeleteService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using var scope = _serviceProvider.CreateScope();
                    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                    // used to delete guest recipes older than 15 minutes
                    var recipeCutoff = DateTime.UtcNow.AddMinutes(-15);

                    var guestRecipes = await dbContext.Recipes
                                        .Include(r => r.User)
                                        .Where(r => r.User.IsGuest && r.PublishedAt < recipeCutoff)
                                        .ToListAsync(stoppingToken);

                    if (guestRecipes.Any())
                    {
                        dbContext.Recipes.RemoveRange(guestRecipes);
                        await dbContext.SaveChangesAsync(stoppingToken);
                        _logger.LogInformation($"Deleted {guestRecipes.Count} guest recipes.");
                    }

                    // Every 12 iterations (3 hours) run loop to check for Guest accounts older than 2 hours old
                    if (_iterationCount % 12 == 0)
                    {
                        // used to delete guest accounts after 2 hours
                        var userCutoff = DateTime.UtcNow.AddHours(-2);

                        var guestUsers = await dbContext.Users
                                            .Where(u => u.IsGuest && u.CreatedAt < userCutoff)
                                            .ToListAsync(stoppingToken);

                        foreach (var guest in guestUsers)
                        {
                            var result = await userManager.DeleteAsync(guest);
                            if (!result.Succeeded) _logger.LogWarning($"Failed to delete {guest.UserName}");
                            _logger.LogInformation($"Delete guest {guest.UserName} successfully.");
                        }
                    }
                    _iterationCount++;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred during cleanup.");
                }

                // Wait 15 minutes before the next iteration
                await Task.Delay(TimeSpan.FromMinutes(15), stoppingToken);
            }
        }
    }
}
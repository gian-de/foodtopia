using Microsoft.EntityFrameworkCore;
using foodtopia.Models;
using foodtopia.Database.Seeds;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace foodtopia.Database
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<HeartedRecipe> HeartedRecipes { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistRecipe> PlaylistRecipes { get; set; }
        public DbSet<HeartedPlaylist> HeartedPlaylists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.Country)
                .WithMany(c => c.Recipes)
                .HasForeignKey(r => r.CountryId);

            modelBuilder.Entity<Country>()
                .HasIndex(c => c.Name)
                .IsUnique();

            // Allow Rating to increment .5 instead of whole numbers
            modelBuilder.Entity<Rating>()
                .Property(r => r.DifficultyRating)
                .HasPrecision(2, 1);
            modelBuilder.Entity<Rating>()
                .Property(r => r.TasteRating)
                .HasPrecision(2, 1);

            // prevents duplicate entries
            modelBuilder.Entity<HeartedRecipe>()
                .HasIndex(hr => new { hr.UserId, hr.RecipeId })
                .IsUnique();
            // Cascade delete HeartedRecipes when a User is deleted
            modelBuilder.Entity<HeartedRecipe>()
                .HasOne(hr => hr.User)
                .WithMany(u => u.HeartedRecipes)
                .HasForeignKey(hr => hr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Prevent cascade delete of Recipe when User is deleted
            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.User)
                .WithMany(u => u.Recipes)
                .HasForeignKey(r => r.UserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            // Cascade delete Ratings when a User is deleted
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cascade delete Ratings when a Recipe is deleted
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Recipe)
                .WithMany(rec => rec.Ratings)
                .HasForeignKey(r => r.RecipeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cascade delete Instructions when a Recipe is deleted
            modelBuilder.Entity<Instruction>()
                .HasOne(instr => instr.Recipe)
                .WithMany(recipe => recipe.Instructions)
                .HasForeignKey(instr => instr.RecipeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cascade delete Ingredients when a Recipe is deleted
            modelBuilder.Entity<Ingredient>()
                .HasOne(ing => ing.Recipe)
                .WithMany(recipe => recipe.Ingredients)
                .HasForeignKey(ing => ing.RecipeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Playlist>()
                    .HasOne(p => p.User)
                    .WithMany(u => u.Playlists)
                    .HasForeignKey(p => p.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Playlist>()
                .HasIndex(p => p.FullSlug).IsUnique();

            modelBuilder.Entity<PlaylistRecipe>(entity =>
            {
                entity.HasKey(pr => new { pr.PlaylistId, pr.RecipeId });

                entity.HasOne(pr => pr.Playlist)
                        .WithMany(p => p.PlaylistRecipes)
                        .HasForeignKey(pr => pr.PlaylistId)
                        .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(pr => pr.Recipe)
                        .WithMany(r => r.PlaylistRecipes)
                        .HasForeignKey(pr => pr.RecipeId)
                        .OnDelete(DeleteBehavior.Cascade);
            });

            // prevents duplicate entries
            modelBuilder.Entity<HeartedPlaylist>()
                .HasIndex(hp => new { hp.UserId, hp.PlaylistId })
                .IsUnique();
            // Cascade delete HeartedPlaylist when a User is deleted
            modelBuilder.Entity<HeartedPlaylist>()
                .HasOne(hp => hp.User)
                .WithMany(u => u.HeartedPlaylists)
                .HasForeignKey(hp => hp.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            // Cascade delete Playlists when a User is deleted
            modelBuilder.Entity<Playlist>()
                .HasOne(p => p.User)
                .WithMany(u => u.Playlists)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<IdentityRole<Guid>>().HasData(RoleSeed.GetRoles());

            var deletedUserGuid = Guid.Parse("00000000-0000-0000-0000-000000000001"); // Well-known GUID for "Deleted" user

            var hashedPassword = File.Exists("seed_password.txt")
                                    ? File.ReadAllText("seed_password.txt").Trim()
                                    : throw new Exception("Missing \"seed_password.txt\". Go to \"https://bcrypt-generator.com/\" type a password and copy the new hashed password and paste it inside the \"seed_password.txt\" file.");

            var deletedUser = new AppUser
            {
                Id = deletedUserGuid,
                UserName = "deleted-user",
                NormalizedUserName = "DELETED-USER",
                Email = "deleted@foodtopia.com",
                NormalizedEmail = "DELETED@FOODTOPIA.COM",
                EmailConfirmed = true,
                PasswordHash = hashedPassword
            };
            modelBuilder.Entity<AppUser>().HasData(deletedUser);

            modelBuilder.Entity<AppUser>().HasData(AppUserSeed.GetAppUsers());

            var countries = CountrySeed.GetCountries(); // variable to pass into both Country entity and argument for RecipeSeed Entity
            // Seed data for Country 1st because the Recipe seed is dependent of it
            modelBuilder.Entity<Country>().HasData(countries);

            // Seed data for Recipes before Instruction and Ingredient seeds since they depend on RecipeId as foreign key
            modelBuilder.Entity<Recipe>().HasData(RecipeSeed.GetRecipes());

            // Seed Instruction then Ingredients
            modelBuilder.Entity<Ingredient>().HasData(IngredientSeed.GetIngredients());
            modelBuilder.Entity<Instruction>().HasData(InstructionSeed.GetInstructions());

            // Seed HeartedRecipes last after User && Recipe Id's have been init
            modelBuilder.Entity<HeartedRecipe>().HasData(HeartedRecipeSeed.GetAll());
        }

        // hacky way to push through warnings that stops executing bug
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .ConfigureWarnings(warnings =>
                    warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
    }
}
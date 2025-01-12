using Microsoft.EntityFrameworkCore;
using foodtopia.Models;
using foodtopia.Database.Seeds;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace foodtopia.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<HeartedRecipe> HeartedRecipes { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            var deletedUserGuid = Guid.Parse("00000000-0000-0000-0000-000000000001"); // Well-known GUID for "Deleted" user
                                                                                      // Special user to represent deleted users and not leave data orphaned
            modelBuilder.Entity<User>().HasData(
                new User { Id = deletedUserGuid, IsDeleted = true, Username = "deleted", FirstName = "Deleted", LastName = "Deleted", Email = "deleted@placeholder.com", Password = "deleted" });

            var countries = CountrySeed.GetCountries(); // variable to pass into both Country entity and argument for RecipeSeed Entity
            // Seed data for Country 1st because the Recipe seed is dependent of it
            modelBuilder.Entity<Country>().HasData(countries);

            // Seed data for Recipes before Instruction and Ingredient seeds since they depend on RecipeId as foreign key
            modelBuilder.Entity<Recipe>().HasData(RecipeSeed.GetRecipes(countries));

            // Seed Instruction then Ingredients
            modelBuilder.Entity<Ingredient>().HasData(IngredientSeed.GetIngredients());
            modelBuilder.Entity<Instruction>().HasData(InstructionSeed.GetInstructions());


            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.Country)
                .WithMany(c => c.Recipes)
                .HasForeignKey(r => r.CountryId);

            modelBuilder.Entity<Country>()
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique()
                .HasFilter("\"Username\" IS NOT NULL"); // this means that multiple null values are allowed, but non-null have to be unique.

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique()
                .HasFilter("\"Email\" IS NOT NULL"); // this means that multiple null values are allowed, but non-null have to be unique.

            modelBuilder.Entity<HeartedRecipe>()
                .HasIndex(hr => new { hr.UserId, hr.RecipeId })
                .IsUnique();

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

            // Cascade delete HeartedRecipes when a User is deleted
            modelBuilder.Entity<HeartedRecipe>()
                .HasOne(hr => hr.User)
                .WithMany(u => u.HeartedRecipes)
                .HasForeignKey(hr => hr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cascade delete HeartedRecipes when a Recipe is deleted
            modelBuilder.Entity<HeartedRecipe>()
                .HasOne(hr => hr.Recipe)
                .WithMany(r => r.HeartedByUsers)
                .HasForeignKey(hr => hr.RecipeId)
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
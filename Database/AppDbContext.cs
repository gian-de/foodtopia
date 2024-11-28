using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using foodtopia.Models;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
    }
}
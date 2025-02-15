using foodtopia.Database;
using foodtopia.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services
{
    public class AccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;
        private readonly Guid deletedUserGuid = Guid.Parse("00000000-0000-0000-0000-000000000001");

        public AccountService(UserManager<AppUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task DeleteAccountAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user is null) throw new KeyNotFoundException("User not found.");

            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // Grab Recipes created from User, then reassign UserId to DeleteGuid id 
                var userRecipes = await _context.Recipes
                                    .Where(r => r.UserId == userId)
                                    .ToListAsync();
                foreach (var recipe in userRecipes)
                {
                    recipe.UserId = deletedUserGuid;
                }

                var userHeartedRecipes = await _context.HeartedRecipes
                                            .Where(r => r.UserId == userId)
                                            .ToListAsync();
                _context.HeartedRecipes.RemoveRange(userHeartedRecipes);

                var userRatings = await _context.Ratings
                                    .Where(r => r.UserId == userId)
                                    .ToListAsync();
                _context.Ratings.RemoveRange(userRatings);

                await _context.SaveChangesAsync();

                var deleteUserResult = await _userManager.DeleteAsync(user);
                if (!deleteUserResult.Succeeded) throw new Exception("Failed to delete account");

                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
using foodtopia.DTOs.User;
using foodtopia.Interfaces.Admin;
using foodtopia.Models;
using Microsoft.AspNetCore.Identity;

namespace foodtopia.Services.Admin
{
    public class SeniorAdminService : ISeniorAdminService
    {
        private readonly UserManager<AppUser> _userManager;
        public SeniorAdminService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<List<UserInfoDTO>> GetAllAdminsAsync()
        {
            var admins = await _userManager.GetUsersInRoleAsync("Admin");
            var seniorAdmins = await _userManager.GetUsersInRoleAsync("Senior Admin");

            var allUsers = admins.Concat(seniorAdmins).ToList();

            var allAdmins = new List<UserInfoDTO>();

            foreach (var user in allUsers)
            {
                var roles = await _userManager.GetRolesAsync(user);
                allAdmins.Add(new UserInfoDTO(
                    Username: user.UserName!,
                    Email: user.Email!,
                    Role: roles.FirstOrDefault()!
                ));
            }

            return allAdmins;
        }

        public async Task<UserInfoDTO> AddAdminRoleAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user is null) throw new KeyNotFoundException("User info passed in wasn't found.");

            bool isAdminAlready = await _userManager.IsInRoleAsync(user, "Admin");
            if (isAdminAlready) throw new ArgumentException("This user is already an admin.");

            if (string.IsNullOrEmpty(user.SecurityStamp))
            {
                user.SecurityStamp = Guid.NewGuid().ToString();
                var updatedUserRole = await _userManager.UpdateAsync(user);

                if (!updatedUserRole.Succeeded) throw new InvalidOperationException("Failed to update user's security stamp.");
            }

            var result = await _userManager.AddToRoleAsync(user, "Admin");
            if (!result.Succeeded) throw new KeyNotFoundException("user error");

            return new UserInfoDTO(
                Username: user.UserName!,
                Email: user.Email!,
                Role: "Admin"
            );
        }


        public async Task<bool> RemoveAdminRoleAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user is null) throw new KeyNotFoundException("User info passed in wasn't found.");

            var roles = await _userManager.GetRolesAsync(user);
            if (!roles.Contains("Admin")) throw new KeyNotFoundException("User is not an Admin.");

            var result = await _userManager.RemoveFromRoleAsync(user, "Admin");
            if (!result.Succeeded) return false;
            return true;
        }
    }
}
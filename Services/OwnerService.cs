using foodtopia.Database;
using foodtopia.DTOs.User;
using foodtopia.Interfaces;
using foodtopia.Models;
using Microsoft.AspNetCore.Identity;

namespace foodtopia.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly UserManager<AppUser> _userManager;

        public OwnerService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<UserInfoDTO> PromoteToOwnerRoleAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user is null) throw new KeyNotFoundException("User not found");

            var currentRoles = await _userManager.GetRolesAsync(user);
            var currentRole = currentRoles.FirstOrDefault();

            if (currentRole == "Owner") throw new ArgumentException("User is already has the Owner role.");

            if (currentRoles.Any())
            {
                var removedRoleResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
                if (!removedRoleResult.Succeeded) throw new InvalidOperationException("Failed to remove existing role.");
            }

            if (string.IsNullOrEmpty(user.SecurityStamp))
            {
                user.SecurityStamp = Guid.NewGuid().ToString();

                var updatedUserRole = await _userManager.UpdateAsync(user);

                if (!updatedUserRole.Succeeded) throw new InvalidOperationException("Failed to update user's security stamp.");
            }

            var result = await _userManager.AddToRoleAsync(user, "Owner");
            if (!result.Succeeded) throw new KeyNotFoundException("Failed to add Owner role to user.");

            return new UserInfoDTO(
                Username: user.UserName!,
                Email: user.Email!,
                Role: "Owner"
            );
        }
        public async Task<UserInfoDTO> PromoteToSeniorAdminRoleAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user is null) throw new KeyNotFoundException("User not found.");

            var currentRoles = await _userManager.GetRolesAsync(user);
            var currentRole = currentRoles.FirstOrDefault();

            if (currentRole == "Senior Admin") throw new ArgumentException("User already has the role \"Senior Admin\"");
            if (currentRole == "Owner") throw new ArgumentException("User has the role \"Owner\". To demote to \"Senior Admin \", use the method for demoting.");

            if (currentRoles.Any())
            {
                var removedRoleResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
                if (!removedRoleResult.Succeeded) throw new InvalidOperationException("Failed to remove user's existing role");
            }

            if (string.IsNullOrEmpty(user.SecurityStamp))
            {
                user.SecurityStamp = Guid.NewGuid().ToString();

                var updatedUserRole = await _userManager.UpdateAsync(user);
                if (!updatedUserRole.Succeeded) throw new InvalidOperationException("Failed to update user's security stamp.");
            }

            var result = await _userManager.AddToRoleAsync(user, "Senior Admin");
            if (!result.Succeeded) throw new KeyNotFoundException("Failed to give user the \"Senior Admin \" role");

            return new UserInfoDTO(
                Username: user.UserName!,
                Email: user.Email!,
                Role: "Senior Admin"
            );
        }
    }
}
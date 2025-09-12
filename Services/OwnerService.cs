using foodtopia.Database;
using foodtopia.DTOs.User;
using foodtopia.Helpers;
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

        public async Task<PagedResult<UserInfoDTO>> GetAllOwnersAsync(int page = 1, int pageSize = 10)
        {
            var owners = await _userManager.GetUsersInRoleAsync("Owner");

            var ownerDTOs = owners.Select(user => new UserInfoDTO(
                Username: user.UserName!,
                Email: user.Email!,
                Role: "Owner"
            )).ToList();

            var totalOwners = ownerDTOs.Count;
            var totalPages = (int)Math.Ceiling((double)totalOwners / pageSize);

            var pagedOwnersDTOs = ownerDTOs
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedResult<UserInfoDTO>
            {
                TotalCount = totalOwners,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = totalPages,
                Results = pagedOwnersDTOs
            };
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

            var promotedToSeniorAdminResult = await _userManager.AddToRoleAsync(user, "Senior Admin");
            if (!promotedToSeniorAdminResult.Succeeded) throw new KeyNotFoundException("Failed to give user the \"Senior Admin \" role");

            return new UserInfoDTO(
                Username: user.UserName!,
                Email: user.Email!,
                Role: "Senior Admin"
            );
        }

        public async Task<UserInfoDTO> DemoteToSeniorAdminRoleAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user is null) throw new KeyNotFoundException("User not found.");

            var currentRoles = await _userManager.GetRolesAsync(user);
            var currentRole = currentRoles.FirstOrDefault();

            if (currentRole == "Senior Admin") throw new ArgumentException("User is already an \"Senior Admin\"");
            if (currentRole == "Admin") throw new ArgumentException("User has role \"Admin\", use the promote to senior admin method instead of demoting upwards.");
            if (currentRole == "User") throw new ArgumentException("User has role \"User\", use the promote to senior admin method instead of demoting upwards.");

            if (currentRoles.Any())
            {
                var removedRoleResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
                if (!removedRoleResult.Succeeded) throw new InvalidOperationException("Failed to remove user's existing role");
            }

            if (string.IsNullOrEmpty(user.SecurityStamp))
            {
                user.SecurityStamp = Guid.NewGuid().ToString();

                var updatedRole = await _userManager.UpdateAsync(user);

                if (!updatedRole.Succeeded) throw new InvalidOperationException("Failed to update user's security stamp.");
            }

            var demotedToSeniorAdminRoleResult = await _userManager.AddToRoleAsync(user, "Senior Admin");
            if (!demotedToSeniorAdminRoleResult.Succeeded) throw new KeyNotFoundException("Failed to give user the \"Senior Admin \" role");

            return new UserInfoDTO(
                Username: user.UserName!,
                Email: user.Email!,
                Role: "Senior Admin"
            );
        }
        public async Task<UserInfoDTO> DemoteToAdminRoleAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user is null) throw new KeyNotFoundException("User not found.");

            var currentRoles = await _userManager.GetRolesAsync(user);
            var currentRole = currentRoles.FirstOrDefault();

            if (currentRole == "Admin") throw new ArgumentException("User is already an \"Admin\"");
            if (currentRole == "User") throw new ArgumentException("User has role \"User\", use the promote to admin method instead of demoting upwards.");

            if (currentRoles.Any())
            {
                var removedRoleResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
                if (!removedRoleResult.Succeeded) throw new InvalidOperationException("Failed to remove user's existing role");
            }

            if (string.IsNullOrEmpty(user.SecurityStamp))
            {
                user.SecurityStamp = Guid.NewGuid().ToString();

                var updatedRole = await _userManager.UpdateAsync(user);

                if (!updatedRole.Succeeded) throw new InvalidOperationException("Failed to update user's security stamp.");
            }

            var demotedToAdminRoleResult = await _userManager.AddToRoleAsync(user, "Admin");
            if (!demotedToAdminRoleResult.Succeeded) throw new KeyNotFoundException("Failed to give user the \"Admin \" role");

            return new UserInfoDTO(
                Username: user.UserName!,
                Email: user.Email!,
                Role: "Admin"
            );
        }
    }
}
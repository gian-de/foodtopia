using foodtopia.DTOs.User;
using foodtopia.Helpers;
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
        public async Task<PagedResult<UserInfoDTO>> GetAllBothSeniorAndAdminsAsync(int page, int pageSize)
        {
            var admins = await _userManager.GetUsersInRoleAsync("Admin");
            var seniorAdmins = await _userManager.GetUsersInRoleAsync("Senior Admin");

            var allUsers = admins.Concat(seniorAdmins).ToList();

            var allAdminsDTOs = new List<UserInfoDTO>();

            foreach (var user in allUsers)
            {
                var roles = await _userManager.GetRolesAsync(user);
                allAdminsDTOs.Add(new UserInfoDTO(
                    Username: user.UserName!,
                    Email: user.Email!,
                    Role: roles.FirstOrDefault()!
                ));
            }

            var totalAdmins = allAdminsDTOs.Count();
            var totalPages = (int)Math.Ceiling((double)totalAdmins / pageSize);
            var pagedAdminsDTOs = allAdminsDTOs
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();

            return new PagedResult<UserInfoDTO>
            {
                TotalCount = totalAdmins,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = totalPages,
                Results = pagedAdminsDTOs
            };
        }
        public async Task<PagedResult<UserInfoDTO>> GetAllSeniorAdminsAsync(int page, int pageSize)
        {
            var seniorAdmins = await _userManager.GetUsersInRoleAsync("Senior Admin");


            var allSeniorAdminsDTOs = new List<UserInfoDTO>();

            foreach (var admin in seniorAdmins)
            {
                var roles = await _userManager.GetRolesAsync(admin);
                allSeniorAdminsDTOs.Add(new UserInfoDTO(
                    Username: admin.UserName!,
                    Email: admin.Email!,
                    Role: roles.FirstOrDefault()!
                ));
            }

            var totalSeniorAdmins = allSeniorAdminsDTOs.Count();
            var totalPages = (int)Math.Ceiling((double)totalSeniorAdmins / pageSize);
            var pagedSeniorAdminsDTOs = allSeniorAdminsDTOs
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();

            return new PagedResult<UserInfoDTO>
            {
                TotalCount = totalSeniorAdmins,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = totalPages,
                Results = pagedSeniorAdminsDTOs
            };
        }
        public async Task<PagedResult<UserInfoDTO>> GetAllNonSeniorAdminsAsync(int page, int pageSize)
        {
            var nonSeniorAdmins = await _userManager.GetUsersInRoleAsync("Admin");


            var allNonSeniorAdminsDTOs = new List<UserInfoDTO>();

            foreach (var admin in nonSeniorAdmins)
            {
                var roles = await _userManager.GetRolesAsync(admin);
                allNonSeniorAdminsDTOs.Add(new UserInfoDTO(
                    Username: admin.UserName!,
                    Email: admin.Email!,
                    Role: roles.FirstOrDefault()!
                ));
            }

            var totalNonSeniorAdmins = allNonSeniorAdminsDTOs.Count();
            var totalPages = (int)Math.Ceiling((double)totalNonSeniorAdmins / pageSize);
            var pagedNonSeniorAdminsDTOs = allNonSeniorAdminsDTOs
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();

            return new PagedResult<UserInfoDTO>
            {
                TotalCount = totalNonSeniorAdmins,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = totalPages,
                Results = pagedNonSeniorAdminsDTOs
            };
        }

        public async Task<UserInfoDTO> AddAdminRoleAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user is null) throw new KeyNotFoundException("User info passed in wasn't found.");

            var currentRoles = await _userManager.GetRolesAsync(user);
            var currentRole = currentRoles.FirstOrDefault();
            if (currentRole == "Owner" || currentRole == "Senior Admin") throw new UnauthorizedAccessException($"Cannot modify a {currentRole}'s role.");
            if (currentRole == "Admin") throw new ArgumentException("User is already an admin.");

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

            var result = await _userManager.AddToRoleAsync(user, "Admin");
            if (!result.Succeeded) throw new KeyNotFoundException("Failed to add admin role.");

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

            var currentRoles = await _userManager.GetRolesAsync(user);
            var currentRole = currentRoles.FirstOrDefault();
            if (currentRole == "Owner" || currentRole == "Senior Admin")
                if (currentRole != "Admin") throw new KeyNotFoundException("User is not an Admin.");

            var result = await _userManager.RemoveFromRoleAsync(user, "Admin");
            if (!result.Succeeded) return false;
            return true;
        }
    }
}
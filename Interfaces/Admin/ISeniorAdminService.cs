using foodtopia.DTOs.User;

namespace foodtopia.Interfaces.Admin
{
    public interface ISeniorAdminService
    {
        Task<UserInfoDTO> AddAdminRoleAsync(Guid userId);
        Task<bool> RemoveAdminRoleAsync(Guid userId);
    }
}
using foodtopia.DTOs.User;
using foodtopia.Helpers;

namespace foodtopia.Interfaces.Admin
{
    public interface ISeniorAdminService
    {
        Task<PagedResult<UserInfoDTO>> GetAllBothSeniorAndAdminsAsync(int page, int pageSize);
        Task<PagedResult<UserInfoDTO>> GetAllSeniorAdminsAsync(int page, int pageSize);
        Task<PagedResult<UserInfoDTO>> GetAllNonSeniorAdminsAsync(int page, int pageSize);
        Task<UserInfoDTO> AddAdminRoleAsync(Guid userId);
        Task<bool> RemoveAdminRoleAsync(Guid userId);
    }
}
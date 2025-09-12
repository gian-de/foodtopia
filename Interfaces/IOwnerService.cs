using foodtopia.DTOs.User;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface IOwnerService
    {
        Task<PagedResult<UserInfoDTO>> GetAllOwnersAsync(int page, int pageSize);
        Task<UserInfoDTO> PromoteToOwnerRoleAsync(Guid userId);
        Task<UserInfoDTO> PromoteToSeniorAdminRoleAsync(Guid userId);
        Task<UserInfoDTO> DemoteToSeniorAdminRoleAsync(Guid userId);
        Task<UserInfoDTO> DemoteToAdminRoleAsync(Guid userId);
    }
}
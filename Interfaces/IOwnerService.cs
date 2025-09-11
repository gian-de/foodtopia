using foodtopia.DTOs.User;

namespace foodtopia.Interfaces
{
    public interface IOwnerService
    {
        Task<UserInfoDTO> PromoteToOwnerRoleAsync(Guid userId);
        Task<UserInfoDTO> PromoteToSeniorAdminRoleAsync(Guid userId);
        
    }
}
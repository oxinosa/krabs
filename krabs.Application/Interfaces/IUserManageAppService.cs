using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using krabs.Application.EventSourcedNormalizers;
using krabs.Application.ViewModels;
using krabs.Application.ViewModels.RoleViewModels;
using krabs.Application.ViewModels.UserViewModels;
using krabs.Domain.Core.ViewModels;

namespace krabs.Application.Interfaces
{
    public interface IUserManageAppService : IDisposable
    {
        Task UpdateProfile(UserViewModel model);
        Task UpdateProfilePicture(ProfilePictureViewModel model);
        Task ChangePassword(ChangePasswordViewModel model);
        Task CreatePassword(SetPasswordViewModel model);
        Task RemoveAccount(RemoveAccountViewModel model);
        Task<bool> HasPassword(Guid userId);
        Task<IEnumerable<EventHistoryData>> GetHistoryLogs(string username);
        Task<UserViewModel> GetUserDetails(string username);
        Task<UserViewModel> GetUserAsync(string userId);
        Task UpdateUser(UserViewModel model);
        Task<IEnumerable<ClaimViewModel>> GetClaims(string userName);
        Task SaveClaim(SaveUserClaimViewModel model);
        Task RemoveClaim(RemoveUserClaimViewModel model);
        Task<IEnumerable<RoleViewModel>> GetRoles(string userName);
        Task RemoveRole(RemoveUserRoleViewModel model);
        Task SaveRole(SaveUserRoleViewModel model);
        Task<IEnumerable<UserLoginViewModel>> GetLogins(string userName);
        Task RemoveLogin(RemoveUserLoginViewModel model);
        Task<IEnumerable<UserListViewModel>> GetUsersInRole(string[] role);
        Task ResetPassword(AdminChangePasswordViewodel model);
        Task<ListOfUsersViewModel> GetUsers(PagingViewModel page);
    }
}
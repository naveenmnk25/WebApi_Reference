using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<string> GetUserNameForLoginAsync(string userId);

        Task<List<ApplicationUserDto>> GetAllUserNameAsync();

        Task AddUserToRole(string userId, string roleName);

        Task<ApplicationUserDto> CheckUserPassword(string userName, string password);

        Task<(Result Result, ApplicationUserDto User)> CreateUserAsync(string userName, string Email, string password, string companyCode);

        Task<bool> UserIsInRole(string userId, string role);

        Task<Result> DeleteUserAsync(string userId);
    }
}

using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.Dto;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<Entity.ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        //public IdentityService(UserManager<ApplicationUser> userManager, IMapper mapper, RoleManager<IdentityRole> roleManager)
        //{
        //    _roleManager = roleManager;
        //    _userManager = userManager;
        //    _mapper = mapper;
        //}

        public IdentityService(UserManager<Entity.ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        //public async Task<CreateUserResponse> Create(User user, string password)
        //{
        //    var appUser = _mapper.Map<Entity.ApplicationUser>(user);
        //    var identityResult = await _userManager.CreateAsync(appUser, password);

        //    if (user.isAdmin)
        //    {
        //        //
        //    }

        //    return new CreateUserResponse(appUser.Id, identityResult.Succeeded, identityResult.Succeeded ? null : identityResult.Errors.Select(e => new Error(e.Code, e.Description)));
        //}

        //public async Task<DeleteUserResponse> DeleteAsync(User user)
        //{
        //    var appUser = await _userManager.FindByNameAsync(user.UserName);
        //    if (appUser == null)
        //    {
        //        return new DeleteUserResponse(0, false, new List<Error> { new Error("User", "User not found") });
        //    }
        //    var identityResult = await _userManager.DeleteAsync(appUser);
        //    return new DeleteUserResponse(appUser.Id, identityResult.Succeeded, identityResult.Succeeded ? null : identityResult.Errors.Select(e => new Error(e.Code, e.Description)));
        //}

        //public async Task<string> GetEmailAsync(User user)
        //{
        //    return await _userManager.GetEmailAsync(_mapper.Map<Entity.ApplicationUser>(user));
        //}

        //public async Task<string> GetUserNameAsync(User user)
        //{
        //    return await _userManager.GetUserNameAsync(_mapper.Map<Entity.ApplicationUser>(user));
        //}

        //public async Task<bool> ResetPasswordAsync(User user, string token, string newPassword)
        //{
        //    return await Task.Run(() =>
        //    {
        //        return _userManager.ResetPasswordAsync(_mapper.Map<Entity.ApplicationUser>(user), token, newPassword).Result.Succeeded;
        //    });
        //}

        //public async Task<User> FindByName(string userName)
        //{
        //    return _mapper.Map<User>(await _userManager.FindByNameAsync(userName));
        //}

        //public async Task<bool> CheckPassword(User user, string password)
        //{
        //    return await _userManager.CheckPasswordAsync(_mapper.Map<Entity.ApplicationUser>(user), password);
        //}

        //public async Task<bool> ConfirmEmailAsync(User user, string password)
        //{
        //    return await Task.Run(() =>
        //    {
        //        return _userManager.ConfirmEmailAsync(_mapper.Map<Entity.ApplicationUser>(user), password).Result.Succeeded;
        //    });

        //}

        public async Task<string> GetUserNameAsync(string userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == userId);

            if (user == null)
            {
                throw new UnauthorizeException();
            }

            return user.UserName;
        }

        public async Task<string> GetUserNameForLoginAsync(string userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == userId);
            return user?.UserName;
        }

        public async Task<List<ApplicationUserDto>> GetAllUserNameAsync()
        {
            var user = await _userManager.Users.ToListAsync();

            if (user == null)
            {
                throw new UnauthorizeException();
            }
            return _mapper.Map<List<ApplicationUserDto>>(user);
        }

        public async Task<ApplicationUserDto> CheckUserPassword(string email, string password)
        {
            Entity.ApplicationUser user = await _userManager.Users.FirstOrDefaultAsync(u => u.Email == email || u.UserName == email);

            if (user != null && await _userManager.CheckPasswordAsync(user, password))
            {
                return _mapper.Map<ApplicationUserDto>(user);
            }

            return null;
        }

        public async Task<(Result Result, ApplicationUserDto User)> CreateUserAsync(string userName, string Email, string password, string companyCode)
        {
            var user = new Entity.ApplicationUser
            {
                UserName = userName,
                Email = Email,
                CompanyCode = companyCode
            };

            var result = await _userManager.CreateAsync(user, password);

            return (result.ToApplicationResult(), _mapper.Map<ApplicationUserDto>(user));
        }

        public async Task<bool> UserIsInRole(string userId, string role)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.UserName == userId);

            return await _userManager.IsInRoleAsync(user, role);
        }

        public async Task AddUserToRole(string userId, string roleName)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.UserName == userId);
            var success = await _userManager.AddToRolesAsync(user, new[] { roleName });
        }

        public async Task<Result> DeleteUserAsync(string userId)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.UserName == userId);

            if (user != null)
            {
                return await DeleteUserAsync(user);
            }

            return Result.Success();
        }

        public async Task<Result> DeleteUserAsync(Entity.ApplicationUser user)
        {
            var result = await _userManager.DeleteAsync(user);

            return result.ToApplicationResult();
        }
    }
}

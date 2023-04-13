using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.Dto;
using CleanArchitecture.Domain.Entities;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Users.Commands.Delete
{
    public class DeleteUserCommand : IRequestWrapper<DeleteUserDto>
    {
        public int Id { get; set; }
    }

    public class DeleteUserCommandHandler : IRequestHandlerWrapper<DeleteUserCommand, DeleteUserDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DeleteUserCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResult<DeleteUserDto>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            //var appUser = await _userManager.FindByNameAsync(user.UserName).ConfigureAwait(false);
            //if (appUser == null)
            //{
            //    return new DeleteUserDto(0, false, new List<Error> { new Error("User", "User not found") });
            //}
            //var identityResult = await _userManager.DeleteAsync(appUser).ConfigureAwait(false);

            //return ServiceResult.Success<DeleteUserDto>(_mapper.Map<DeleteUserDto>(entity));
            return null;
        }
    }
}

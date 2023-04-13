using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.Dto;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Event;
using MapsterMapper;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ApplicationUser.Commands.Create
{
    public class CreateApplicationUserCommand : IRequestWrapper<ApplicationUserDto>
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CompanyCode { get; set; }
    }

    public class CreateApplicationUserCommandHandler : IRequestHandlerWrapper<CreateApplicationUserCommand, ApplicationUserDto>
    {
        private readonly IMapper _mapper;
        private readonly IIdentityService _identityService;

        public CreateApplicationUserCommandHandler(IIdentityService identityService, IMapper mapper)
        {
            _mapper = mapper;
            _identityService = identityService;
        }

        public async Task<ServiceResult<ApplicationUserDto>> Handle(CreateApplicationUserCommand request, CancellationToken cancellationToken)
        {
            var entity = new User
            {
                UserName = request.UserName,
                Email = request.Email,
                Password = request.Password,
                CompanyCode = request.CompanyCode
            };

            entity.DomainEvents.Add(new UserCreatedEvent(entity));

            var data = await _identityService.CreateUserAsync(entity.UserName, entity.Email, entity.Password, entity.CompanyCode);
            await _identityService.AddUserToRole(entity.UserName, "Administrator");
            return ServiceResult.Success(data.User);
        }
    }
}
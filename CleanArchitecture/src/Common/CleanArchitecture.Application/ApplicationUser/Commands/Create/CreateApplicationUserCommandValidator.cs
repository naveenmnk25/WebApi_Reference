using CleanArchitecture.Application.ApplicationUser.Commands.Create;
using CleanArchitecture.Application.Common.Interfaces;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Cities.Commands.Create
{
    public class CreateApplicationUserCommandValidator : AbstractValidator<CreateApplicationUserCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IIdentityService _identityService;

        public CreateApplicationUserCommandValidator(IIdentityService identityService, IApplicationDbContext context)
        {
            _context = context;
            _identityService = identityService;

            RuleFor(v => v.UserName)
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.")
                .MustAsync(BeUniqueName).WithMessage("The specified ApplicationUser already exists.")
                .NotEmpty().WithMessage("Name is required.");
        }

        private async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
        {
            //TODO: Control by uppercase and CultureInfo
            return await _identityService.GetUserNameForLoginAsync(name) == null;
        }
    }
}

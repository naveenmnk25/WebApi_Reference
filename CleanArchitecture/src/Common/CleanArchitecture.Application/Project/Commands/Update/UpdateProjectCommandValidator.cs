using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Projects.Commands.Update;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Cities.Commands.Update
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        private readonly IApplicationDbContext _context;
        public UpdateProjectCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.Name)
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(v => v.ProjectId).NotNull();
        }

        private async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
        {
            return await _context.Project.AllAsync(x => x.Name != name, cancellationToken);
        }
    }
}

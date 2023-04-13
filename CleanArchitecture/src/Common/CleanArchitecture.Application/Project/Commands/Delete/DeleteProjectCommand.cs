using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.Dto;
using CleanArchitecture.Domain.Entities;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Projects.Commands.Delete
{
    public class DeleteProjectCommand : IRequestWrapper<ProjectDto>
    {
        public int Id { get; set; }
    }

    public class DeleteProjectCommandHandler : IRequestHandlerWrapper<DeleteProjectCommand, ProjectDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DeleteProjectCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResult<ProjectDto>> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Project
                .Where(l => l.ProjectId == request.Id)
                .SingleOrDefaultAsync(cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Project), request.Id);
            }

            _context.Project.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return ServiceResult.Success(_mapper.Map<ProjectDto>(entity));
        }
    }
}

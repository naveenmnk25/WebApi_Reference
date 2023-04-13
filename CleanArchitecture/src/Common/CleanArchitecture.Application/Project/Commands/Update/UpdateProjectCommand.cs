using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.Dto;
using CleanArchitecture.Domain.Entities;
using MapsterMapper;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Projects.Commands.Update
{
    public class UpdateProjectCommand : IRequestWrapper<ProjectDto>
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Description { get; set; }
    }

    public class UpdateProjectCommandHandler : IRequestHandlerWrapper<UpdateProjectCommand, ProjectDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UpdateProjectCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResult<ProjectDto>> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Project.FindAsync(request.ProjectId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Project), request.ProjectId);
            }
            if (!string.IsNullOrEmpty(request.Name))
            {
                entity.Name = request.Name;
                entity.Description = request.Description;
            }

            await _context.SaveChangesAsync(cancellationToken);

            return ServiceResult.Success(_mapper.Map<ProjectDto>(entity));
        }
    }
}

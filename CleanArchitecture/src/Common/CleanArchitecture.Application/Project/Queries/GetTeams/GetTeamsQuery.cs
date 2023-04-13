using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.Dto;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Projects.Queries.GetProjects
{
    public class GetProjectsQuery : IRequestWrapper<List<ProjectDto>>
    {
        public int? ProjectId { get; set; }
    }

    public class GetProjectsQueryHandler : IRequestHandlerWrapper<GetProjectsQuery, List<ProjectDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProjectsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResult<List<ProjectDto>>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
        {
            List<ProjectDto> list = await _context.Project
                .Where(x => x.ProjectId == request.ProjectId || request.ProjectId == null)
                .ProjectToType<ProjectDto>(_mapper.Config)
                .ToListAsync(cancellationToken);

            return list.Count > 0 ? ServiceResult.Success(list) : ServiceResult.Failed<List<ProjectDto>>(ServiceError.NotFound);
        }
    }
}

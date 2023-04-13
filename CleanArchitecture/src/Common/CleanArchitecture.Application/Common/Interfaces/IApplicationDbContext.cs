using CleanArchitecture.Application.Dto;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DatabaseFacade dbContext { get; }
        DbSet<Project> Project { get; set; }
        DbSet<ExecuteResult> ExecuteResult { get; set; }
        DbSet<QueryResult> QueryResult { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

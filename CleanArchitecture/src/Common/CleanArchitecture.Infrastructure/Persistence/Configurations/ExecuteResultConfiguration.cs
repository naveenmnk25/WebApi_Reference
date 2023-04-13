using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    public class ExecuteResultConfiguration : IEntityTypeConfiguration<ExecuteResult>
    {
        public void Configure(EntityTypeBuilder<ExecuteResult> builder)
        {
            builder.HasNoKey();
        }
    }
}

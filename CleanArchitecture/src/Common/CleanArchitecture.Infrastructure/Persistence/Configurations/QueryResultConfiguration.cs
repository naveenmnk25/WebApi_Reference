using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    public class QueryResultConfiguration : IEntityTypeConfiguration<QueryResult>
    {
        public void Configure(EntityTypeBuilder<QueryResult> builder)
        {
            builder.HasNoKey();
        }
    }
}

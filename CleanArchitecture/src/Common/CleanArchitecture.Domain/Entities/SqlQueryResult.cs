using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Entities
{
    [NotMapped]
    [Keyless]
    public class SqlQueryResult<T>
    {
        public T JsonResult { get; set; }
    }
}

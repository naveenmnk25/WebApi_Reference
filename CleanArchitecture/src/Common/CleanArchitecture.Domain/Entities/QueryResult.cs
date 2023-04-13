using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Entities
{
    [NotMapped]
    [Keyless]
    public class QueryResult
    {
        public string JsonResult { get; set; }
    }
}

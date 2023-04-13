using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Entities
{
    [NotMapped]
    public class ExecuteResult
    {
        public int Result { get; set; }
    }
}

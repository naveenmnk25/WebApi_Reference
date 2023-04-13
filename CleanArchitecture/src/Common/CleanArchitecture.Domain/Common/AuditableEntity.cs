using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Common
{
    public abstract class AuditableEntity
    {
        public int? CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}

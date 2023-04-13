using CleanArchitecture.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Entities
{
    public class User : AuditableEntity, IHasDomainEvent
    {
        public User()
        {
            DomainEvents = new List<DomainEvent>();
        }

        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CompanyCode { get; set; }
        public List<DomainEvent> DomainEvents { get; set; }
    }
}

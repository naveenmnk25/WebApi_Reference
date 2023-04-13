using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Event;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Entities
{
    public class Project : AuditableEntity, IHasDomainEvent
    {
        public Project()
        {
            DomainEvents = new List<DomainEvent>();
        }

        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private bool _active;
        public bool Active
        {
            get => _active;
            set
            {
                if (value && _active == false)
                {
                    DomainEvents.Add(new ProjectActivatedEvent(this));
                }
                _active = value;
            }
        }
        public List<DomainEvent> DomainEvents { get; set; }

    }
}

using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Event
{
    public class ProjectActivatedEvent : DomainEvent
    {
        public ProjectActivatedEvent(Project project)
        {
            Project = project;
        }

        public Project Project { get; }
    }
}

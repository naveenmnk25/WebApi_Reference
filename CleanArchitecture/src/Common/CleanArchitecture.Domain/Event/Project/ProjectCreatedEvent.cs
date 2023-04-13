using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Event
{
    public class ProjectCreatedEvent : DomainEvent
    {
        public ProjectCreatedEvent(Project project)
        {
            Project = project;
        }

        public Project Project { get; }
    }
}

using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Domain.Event;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Cities.EventHandler
{
    public class ProjectActivatedEventHandler : INotificationHandler<DomainEventNotification<ProjectActivatedEvent>>
    {
        private readonly ILogger<ProjectActivatedEventHandler> _logger;
        private readonly IEmailService _emailService;

        public ProjectActivatedEventHandler(ILogger<ProjectActivatedEventHandler> logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        public async Task Handle(DomainEventNotification<ProjectActivatedEvent> notification, CancellationToken cancellationToken)
        {
            var domainEvent = notification.DomainEvent;

            _logger.LogInformation("CleanArchitecture CleanArchitecture.Domain Event: {DomainEvent}", domainEvent.GetType().Name);

            if (domainEvent.Project != null)
            {
                await _emailService.SendEmailAsync(new EmailRequest
                {
                    Subject = domainEvent.Project.Name + " is activated.",
                    Body = "Project is activated successfully.",
                    FromDisplayName = "Clean Architecture",
                    FromMail = "test@test.com",
                    ToMail = new List<string> { "sathiyamoorthy@euroland.com", "yamunadevi.nagarajan@euroland.com" }
                });
            }
        }
    }
}

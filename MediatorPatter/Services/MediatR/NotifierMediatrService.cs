using MediatorPattern.Interfaces;
using MediatorPattern.Models;
using MediatR;

namespace MediatorPattern.Services.MediatR
{
    public class NotifierMediatrService : INotifierMediatrService
    {
        private readonly IMediator _mediator;

        public NotifierMediatrService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Notify(string notifyText)
        {
            _mediator.Publish(new NotificationMessage { NotifyText = notifyText });
        }
    }
}

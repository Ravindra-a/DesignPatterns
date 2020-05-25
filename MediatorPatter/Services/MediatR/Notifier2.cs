using MediatorPattern.Models;
using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPattern.Services.MediatR
{
    public class Notifier2 : INotificationHandler<NotificationMessage>
    {
        public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Debugging from Notifier 1. Message  : {notification.NotifyText} ");
            return Task.CompletedTask;
        }
    }
}

using MediatorPattern.Interfaces;
using MediatR;

namespace MediatorPattern.Models
{
    public class NotificationMessage : INotification
    {
        public string NotifyText { get; set; }
    }
}

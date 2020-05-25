using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern.Interfaces
{
    public interface INotifierMediatorService
    {
        Task<IEnumerable<string>> NotifyAsync();

        Task<IEnumerable<string>> ConditionalNotifyAsync(bool input);
    }
}

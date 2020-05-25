using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern.Interfaces
{
    public interface INotifier
    {
        Task<String> NotifyAsync();
        IAsyncEnumerable<String> NotifyAsyncYield();

        bool CanRun();
    }
}

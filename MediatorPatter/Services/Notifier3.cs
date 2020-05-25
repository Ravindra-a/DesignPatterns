using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern.Services
{
    public class Notifier3 : INotifier
    {
        public bool CanRun()
        {
            return false;
        }

        public async Task<string> NotifyAsync()
        {
            await Task.Delay(100);
            return "Debugging from Notifier 3";
        }

        public async IAsyncEnumerable<String> NotifyAsyncYield()
        {
            await Task.Delay(100);
            yield return "Debugging from Notifier 1";
        }
    }
}

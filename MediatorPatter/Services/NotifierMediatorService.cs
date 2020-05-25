using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern.Services
{
    public class NotifierMediatorService : INotifierMediatorService
    {
        private readonly IEnumerable<INotifier> notifiers;

        public NotifierMediatorService(IEnumerable<INotifier> notifiers)
        {
            this.notifiers = notifiers;
        }

        public async Task<IEnumerable<string>> NotifyAsync()
        {
            List<string> output = new List<string>();
            foreach (Task<string> notify in notifiers.ToList().Select(x => x.NotifyAsync()))
            {
                output.Add(await notify);
            }
            return output;
        }

        public async Task<IEnumerable<string>> ConditionalNotifyAsync(bool input)
        {
            List<string> output = new List<string>();
            foreach (Task<string> notify in notifiers.Where(x => x.CanRun() == input).ToList().Select(x => x.NotifyAsync()))
            {
                output.Add(await notify);
            }
            return output;
        }
    }
}

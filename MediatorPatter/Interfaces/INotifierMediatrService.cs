using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern.Interfaces
{
    public interface INotifierMediatrService
    {
        void Notify(string notifyText);
    }
}

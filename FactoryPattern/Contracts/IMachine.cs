using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Contracts
{
    public interface IMachine
    {
        string Name { get; }
        void TurnOn();
        void TurnOff();
    }
}

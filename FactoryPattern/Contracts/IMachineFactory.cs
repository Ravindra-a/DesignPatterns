using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Contracts
{
    public interface IMachineFactory
    {
        IMachine CreateInstance(string description);
    }
}

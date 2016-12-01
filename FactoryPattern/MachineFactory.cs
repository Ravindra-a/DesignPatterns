using FactoryPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MachineFactory : IMachineFactory
    {
        Dictionary<string, Type> machines;
        public MachineFactory()
        {
            LoadTypesICanReturn();
        }

        private void LoadTypesICanReturn()
        {
            machines = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IMachine).ToString()) != null)
                {
                    machines.Add(type.Name.ToLower(), type);
                }
            }
        }

        public IMachine CreateInstance(string machineName)
        {
            Type t = GetTypeToCreate(machineName);

            if (t == null)
                return new UnknownMachine();

            return Activator.CreateInstance(t) as IMachine;
        }

        private Type GetTypeToCreate(string machineName)
        {
            foreach (var machine in machines)
            {
                if (machine.Key.Contains(machineName))
                {
                    return machines[machine.Key];
                }
            }

            return null;
        }
    }
}

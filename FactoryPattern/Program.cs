using FactoryPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string machineName = args[0];
            //IMachine machine = GetMachine(machineName);
            //IMachine machine = new MachineFactory().CreateInstance(machineName);
            IMachine machine = LoadFactory().CreateInstance(machineName);
            machine.TurnOn();
            machine.TurnOff();
            Console.ReadLine();
        }
        private static IMachineFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.DefaultMachineFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IMachineFactory;
        }

        //static IMachine GetMachine(string machineName)
        //{
        //    switch(machineName)
        //    {
        //        case "robot":
        //            return new Robot();
        //        case "car":
        //            return new Car();
        //        case "microwave":
        //            return new MicrowaveOven();
        //        default:
        //            return new UnknownMachine();
        //    }
        //}
    }
}

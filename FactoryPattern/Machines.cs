using FactoryPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Robot : IMachine
    {
        public string Name
        {
            get { return "robot"; }
        }

        public void TurnOn()
        {
            Console.WriteLine("Robot is starting.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Robot is stopping.");
        }
    }

    public class Car : IMachine
    {
        public string Name
        {
            get { return "car"; }
        }

        public void TurnOn()
        {
            Console.WriteLine("Car is starting.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Car is stopping.");
        }
    }

    public class MicrowaveOven : IMachine
    {
        public string Name
        {
            get { return "microwave oven"; }
        }

        public void TurnOn()
        {
            Console.WriteLine("Microwave oven is starting.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Microwave oven is stopping.");
        }
    }

    public class UnknownMachine : IMachine
    {
        public string Name
        {
            get { return string.Empty; }
        }

        public void TurnOn()
        {

        }

        public void TurnOff()
        {

        }
    }
}

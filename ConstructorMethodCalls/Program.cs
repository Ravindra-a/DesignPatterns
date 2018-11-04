using System;

namespace ConstructorMethodCalls
{
    class Program
    {
        static void Main(string[] args)
        {

            ChildClass obj = new ChildClass();
            obj.BaseMethod();
        }
    }

    public class BaseClass
    {
        //public BaseClass()
        //{
        //    Console.WriteLine("base constructor called");
        //}
        public virtual void BaseMethod()
        {
            Console.WriteLine("Base Method called");
        }
    }

    public class ChildClass : BaseClass
    {
        //public ChildClass()
        //{
        //    Console.WriteLine("child constructor called");
        //}
        public new void BaseMethod()
        {
            Console.WriteLine("Child Method called");
        }
    }
}

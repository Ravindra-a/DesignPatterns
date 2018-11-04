using Singleton.Contracts;
using Singleton.IOCResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Singleton
{
    class Program
    {
        private static UnityDependencyResolver _dependencyResolver;
        private static INumberWriter _numberWriter;

        private static void RegisterTypes()
        {
            _dependencyResolver = new UnityDependencyResolver();
            _dependencyResolver.EnsureDependenciesRegistered();
            _dependencyResolver.Container.RegisterType<INumberWriter, AsyncNumberWriter>();

        }
        static void Main(string[] args)
        {
            #region "beforefieldinit"
            //http://csharpindepth.com/Articles/General/Beforefieldinit.aspx
            //Console.WriteLine("Starting Main");
            //// Invoke a static method on Test
            //Test.EchoAndReturn("Echo!");
            //Console.WriteLine("After echo");
            //// Reference a static field in Test
            //string y = Test.x;
            //// Use the value just to avoid compiler cleverness
            //if (y != null)
            //{
            //    Console.WriteLine("After field access");
            //}
            #endregion

            RegisterTypes();
            _numberWriter = _dependencyResolver.Container.Resolve<INumberWriter>();
            _numberWriter.WriteNumbersToFile(100);
            Console.WriteLine("File write done.");
            Console.ReadKey();
        }
    }

    class Test
    {
        public static string x = EchoAndReturn("In type initializer");

        public static string EchoAndReturn(string s)
        {
            Console.WriteLine(s);
            return s;
        }
    }
}

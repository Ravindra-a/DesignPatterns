using Microsoft.Practices.Unity;
using Singleton.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.IOCResolver
{
    public class UnityDependencyResolver
    {
        private static readonly IUnityContainer _container;
        static UnityDependencyResolver()
        {
            _container = new UnityContainer();
            IoC.Initialize(_container);
        }

        public void EnsureDependenciesRegistered()
        {
            _container.RegisterType<IFileLoggerFactory, FileLoggerFactory>();
        }

        public IUnityContainer Container
        {
            get
            {
                return _container;
            }
        }
    }
}

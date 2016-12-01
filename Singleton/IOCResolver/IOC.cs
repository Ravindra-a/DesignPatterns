using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.IOCResolver
{
    public static class IoC
    {
        private static IUnityContainer _container;

        public static void Initialize(IUnityContainer container)
        {
            _container = container;
        }

        public static TBase Resolve<TBase>()
        {
            return _container.Resolve<TBase>();
        }
    }
}

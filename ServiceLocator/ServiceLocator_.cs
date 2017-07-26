using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
    public static class ServiceLocator_
    {

        private static readonly Dictionary<Type, object> registeredServices = new Dictionary<Type, object>();

        public static T GetService<T>()

        {

            return (T)registeredServices[typeof(T)];

        }

        public static void RegisterService<T>(T service)

        {

            registeredServices[typeof(T)] = service;

        }

        public static Int32 Count

        {

            get { return registeredServices.Count; }

        }
    }
}

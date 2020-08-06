using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    class ServiceLocator : IServiceLocator
    {
        // map that contains pairs of interfaces and
        // references to concrete implementations
        private IDictionary<object, object> services;

        internal ServiceLocator()
        {
            services = new Dictionary<object, object>();

            // fill the map
            //Regestering 
            this.services.Add(typeof(IServiceA), new ServiceA());
            this.services.Add(typeof(IServiceB), new ServiceB());
            this.services.Add(typeof(IServiceC), new ServiceC());
        }

        public T GetService<T>()
        {
            try
            {
                return (T)services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }
    }
}

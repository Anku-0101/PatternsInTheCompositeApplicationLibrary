using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.MethodInjection
{
    class Service1 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service 1 called");
        }
    }
}

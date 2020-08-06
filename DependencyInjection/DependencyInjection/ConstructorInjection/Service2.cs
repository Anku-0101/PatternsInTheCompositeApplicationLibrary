using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.ConstructorInjection
{
    class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service 2 called");
        }
    }
}

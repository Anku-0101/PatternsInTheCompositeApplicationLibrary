using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    class ServiceC : IServiceC
    {
        public void MethodC()
        {
            Console.WriteLine("Service C Called");
        }
    }
}

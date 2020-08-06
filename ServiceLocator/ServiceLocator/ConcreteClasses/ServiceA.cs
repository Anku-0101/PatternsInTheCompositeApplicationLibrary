using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    class ServiceA : IServiceA
    {
        public void MethodA()
        {
            Console.WriteLine("Service A Called");
        }
    }
}

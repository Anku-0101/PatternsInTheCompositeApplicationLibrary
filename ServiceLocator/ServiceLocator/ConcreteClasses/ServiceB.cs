using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    class ServiceB : IServiceB
    {
        public void MethodB()
        {
            Console.WriteLine("Service B Called");
        }
    }
}

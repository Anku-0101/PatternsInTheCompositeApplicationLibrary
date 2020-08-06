using System;

namespace ServiceLocator
{
    class Client
    {
        static void Main(string[] args)
        {
            IServiceLocator locator = new ServiceLocator();
            IServiceA myServiceA = locator.GetService<IServiceA>();

            myServiceA.MethodA();
        }
    }
}

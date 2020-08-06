using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.MethodInjection
{
    class Client
    {
        public void Start(IService service)
        {
            service.Serve();
        }
    }
}

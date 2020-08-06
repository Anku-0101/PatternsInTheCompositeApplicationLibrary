using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.ConstructorInjection
{
    class Client
    {
        private IService _service;

        //More splified by using container
        public Client(IService service)
        {
            this._service = service;
        }
        public void ServeMethod() { this._service.Serve(); }
    }
}


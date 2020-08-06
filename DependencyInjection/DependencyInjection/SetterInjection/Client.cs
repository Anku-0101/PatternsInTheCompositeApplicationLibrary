using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DependencyInjection.SetterInjection
{
    class Client
    {
        private IService _service;
        public IService Service
        {
            set { this._service = value; }
        }
        public void ServeMethod() 
        { 
            this._service.Serve(); 
        }
    }
}

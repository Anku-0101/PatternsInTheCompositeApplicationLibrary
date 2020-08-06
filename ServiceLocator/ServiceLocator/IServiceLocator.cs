using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    interface IServiceLocator
    {
        T GetService<T>();
    }
}

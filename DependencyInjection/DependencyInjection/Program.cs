using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Constructor Injection
             */
             
            //Creating Object
            ConstructorInjection.Service1 service1 = new ConstructorInjection.Service1();

            //Passing Dependency
            ConstructorInjection.Client client1 = new ConstructorInjection.Client(service1);

            //DO the job
            //client1.ServeMethod();

            /*
             * Setter(Property) Injection
             */

            //Creating object
            SetterInjection.Service1 service11 = new SetterInjection.Service1();

            SetterInjection.Client client2 = new SetterInjection.Client();

            //Passing Dependency
            client2.Service = service11;

            //DO the job
            //client2.ServeMethod();


            /*
             * Method Injection
             */
             
            //Creating Object
            MethodInjection.Service2 service2 = new MethodInjection.Service2();

            MethodInjection.Client client3 = new MethodInjection.Client();

            //Passing Dependency 
            client3.Start(service2);
        }
    }
}

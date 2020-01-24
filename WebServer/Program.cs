using System;

namespace WebServer
{
    //Chain of responsibility

    //Create a server , with configurable request pipeline

    class Program
    {
        static void Main(string[] args)
        {
            var listener = new Listener();
            listener.handlers = new AuthenticationHandler(new AuthorizationHandler(null));

            var server = new WebServer(listener);
            server.Start();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            server.Stop();

            Console.ReadLine();
        }
    }
}

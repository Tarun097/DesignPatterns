using System;

namespace WebServer
{
    public class Listener : IHttpListner
    {
        public Handler handlers { get; set; }

        public void Open()
        {
            Console.WriteLine("Listener started");
        }

        public void Listen()
        {
            HandleRequest(new HttpRequest());
        }

        private void HandleRequest(HttpRequest request)
        {
            
            handlers.HandleRequest(request);
        }

        public void Close()
        {
            Console.WriteLine("Listener stopped");
        }
    }
}
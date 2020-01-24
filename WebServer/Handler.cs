using System;

namespace WebServer
{
    public abstract class Handler
    {
        protected Handler successor;
        protected Handler(Handler successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(HttpRequest request);
    }

    public class AuthenticationHandler : Handler
    {
        public AuthenticationHandler(Handler successor) : base(successor)
        {
        }
        public override void HandleRequest(HttpRequest request)
        {
            Console.WriteLine("Request Authenticated");
            if (successor != null)
            {
                this.successor.HandleRequest(request);
            }
        }
    }
    public class AuthorizationHandler : Handler
    {
        public AuthorizationHandler(Handler successor) : base(successor)
        {
        }
        public override void HandleRequest(HttpRequest request)
        {
            Console.WriteLine("Request Authorized");
            if (successor != null)
            {
                this.successor.HandleRequest(request);
            }
        }
    }
}
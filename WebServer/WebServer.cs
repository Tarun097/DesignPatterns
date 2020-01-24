using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    public class WebServer: IServer
    {
        private IHttpListner listner;

        public WebServer(IHttpListner listner)
        {
            this.listner = listner;
        }
        public void Start()
        {
            Console.WriteLine("Server running ...");
            listner.Open();
            listner.Listen();
        }

        public void Stop()
        {
            listner.Close();
            Console.WriteLine("Server stopped");
        }
    }

    public interface IHttpListner
    {
        void Open();

        void Close();

        void Listen();
    }
}

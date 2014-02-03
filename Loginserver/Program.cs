using Loginserver.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Loginserver
{
    class Program
    {
        public static HttpListener httpListener;

        static void Main(string[] args)
        {
            httpListener = new HttpListener(6600);

            Thread thread = new Thread(new ThreadStart(httpListener.listen));
            thread.Start();
        }
    }
}

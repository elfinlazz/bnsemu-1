using common.net;
using common.util;
using Loginserver.net.Channel.Sts;
using System.IO;

namespace Loginserver.net
{
    class HttpListener : HttpServer
    {
        private static RequestPacketHandler packetHandler = RequestPacketHandler.getInstance();

        public HttpListener(int port)
            : base(port)
        {
        }

        public override void handleGETRequest(HttpProcessor p)
        {
            
        }

        public override void handlePOSTRequest(HttpProcessor p, System.IO.StreamReader inputData)
        {
            AbstractRequestPacket packet = packetHandler.getPacket(p.http_url);
            packet.Data = inputData.ReadToEnd();
            packet.read();
            packet.execute();
        }
    }
}

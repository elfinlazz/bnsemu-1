using common.util;
using Loginserver.net.Model.Sts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loginserver.net.Channel.Sts
{
    public class RequestConnect : AbstractRequestPacket
    {
        protected ConnectModel Model;

        public override void read()
        {
            Model = XmlSerializer.Deserialize<ConnectModel>(Data);
        }

        public override void execute()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loginserver.net
{
    public abstract class AbstractRequestPacket
    {
        public string Data;

        public abstract void read();

        public abstract void execute();
    }
}

using common.util;
using Loginserver.net.Channel.Sts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Loginserver.net
{
    public class RequestPacketHandler
    {
        private static RequestPacketHandler ourInstance = new RequestPacketHandler();

        public static RequestPacketHandler getInstance()
        {
            return ourInstance;
        }

        private RequestPacketHandler()
        {
        }

        public AbstractRequestPacket getPacket( String url )
        {
            Log.Info("URL: {0}", url);

            switch( url )
            {
                case "/Sts/Connect":
                    return new RequestConnect();
                case "/Sts/Ping":
                //    return new RequestPing();
                case "/Auth/LoginStart":
                //    return new RequestLoginStart();
                case "/Auth/KeyData":
                //   return new RequestKeyData();
                case "/Auth/LoginFinish":
                case "/Auth/RequestToken":
                case "/Auth/RequestGameToken":
                case "/Auth/GetMyUserInfo":
                case "/GameAccount/ListMyAccounts":
                case "/World/ListWorlds":
                case "/Slot/ListCharSlots":
                case "/Slot/GetCharSlot":
                case "/Slot/ListSlots":
                case "/Game.bns/CreatePC":
                case "/Game.bns/DeletePC":
                case "/SecondPassword/GetStatus":
                case "/Grade.bns/GetGameGrade":
                case "/Friend/GetUserInfo":
                case "/VirtualCurrency/GetBalance":
                case "/Friend/PageRecvProposals":
                default:
                    throw new IOException( "No handler available for request " + url );
            }
        }
    }
}

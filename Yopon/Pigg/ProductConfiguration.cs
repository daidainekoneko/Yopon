using System.Net;

namespace Yopon.Pigg
{
    public static class ProductConfiguration
    {
        public static IPAddress LocalIP => IPAddress.Loopback;

        public static bool UseInfoServerGip = false;

        public static string ServerGroupState = "active";

        public static string InfoWebSocketUrl =>
            InfoWebSocketProtocol + "://" + InfoHost + ":" + InfoWebSocketPort + "/command";

        public static string InfoWebSocketProtocol => "wss";

        public static string InfoHost
        {
            get
            {
                if (!UseInfoServerGip)
                {
                    return "info.pigg.ameba.jp";
                }
                if (ServerGroupState == "active")
                {
                    return "27" + "." + "133" + "." + "213" + "." + "64";
                }
                if (ServerGroupState == "standby")
                {
                    return "27" + "." + "133" + "." + "213" + "." + "75";
                }
                return "";
            }
        }

        public static int InfoWebSocketPort => 443;
    }
}
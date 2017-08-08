using System;
using System.Drawing;

namespace Yopon.Pigg
{
    public static class ActiveUser
    {
        public static IPiggProxy InfoProxy { get; set; }

        public static IPiggProxy ChatProxy { get; set; }

        public static string ApplicationBase =>
            AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        public static string UsersFileDir
        {
            get
            {
                var amebaId = AmebaId;

                if (string.IsNullOrEmpty(amebaId))
                    amebaId = AsUserId;

                if (string.IsNullOrEmpty(amebaId))
                    throw new Exception("IDがありません");

                return $@"{ApplicationBase}users\{amebaId}\";
            }
        }

        public static string ChatLogFileDir => $@"{UsersFileDir}chat\";

        public static string ChatLogFilePath => $"{ChatLogFileDir}" +
            $"{DateTime.Now.ToString("yyyy年MM月dd日")}.txt";

        public static string AmebaId { get; internal set; }

        public static string HexCode { get; internal set; }

        public static string AsUserId { get; internal set; }

        public static string Nickname { get; internal set; }

        public static bool IsOneClickTeleport { get; set; }

        public static Color TalkBGColor = Color.White;
    }
}
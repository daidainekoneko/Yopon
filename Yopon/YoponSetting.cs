using Yopon.Serializer;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Yopon
{
    [Serializable]
    public class YoponSetting
    {
        #region "System"

        [XmlIgnore]
        public static string Directory => AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        [XmlIgnore]
        public static string SwfSaveDir => $"{Directory}swf\\";

        [XmlIgnore]
        public static string ConfigFile => $"{Directory}config.xml";

        [XmlIgnore]
        public static string DebugLogFile => $"{Directory}yopon-debug.txt";

        [XmlIgnore]
        public static YoponSetting I { get; set; }

        static YoponSetting()
        {
            Load();
        }

        public static void Load()
        {
            if (File.Exists(ConfigFile))
            {
                System.IO.Directory.CreateDirectory(Directory);
                var serializer = new XmlSerializer<YoponSetting>();
                I = serializer.Deserialize(ConfigFile);
            }

            if (I == null)
                I = new YoponSetting();
        }

        public static void Save()
        {
            var s = new XmlSerializer<YoponSetting>();

            try
            {
                var serial = new XmlSerializer<YoponSetting>();
                System.IO.Directory.CreateDirectory(Directory);
                serial.Serialize(ConfigFile, I);
            }
            catch (Exception) { }
        }

        #endregion "System"

        public bool HideSandboxError = true;

        public bool IsAgreed = false;

        public bool IsDebugMode = false;

        public bool HasDownloadModule = false;

        public bool HasBlockIllegalAction = true;

        public bool HasSaveChatLog = true;

        public bool HasSaveSlashMessage = false;

        public bool HasProcessFormat = false;

        public string LogFormat = "[$time] $name ($amebaId): $message";
    }
}
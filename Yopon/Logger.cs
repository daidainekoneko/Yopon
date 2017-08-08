using System.IO;
using System.Threading.Tasks;

namespace Yopon
{
    public class Logger
    {
        private static object syncObject = new object();

        public static void Output(string path, string log)
        {
            lock (syncObject)
            {
                var directory = Path.GetDirectoryName(path);

                if (Directory.Exists(directory) == false)
                    Directory.CreateDirectory(directory);

                File.AppendAllText(path, $"{log}\r\n");
            }
        }

        public static void OutputAtBackground(string path, string log)
        {
            Task.Run(() => Output(path, log));
        }
    }
}
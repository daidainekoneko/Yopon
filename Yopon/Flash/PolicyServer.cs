using Yopon.Pigg;
using Fleck;
using System.Threading.Tasks;

namespace Yopon.Flash
{
    public class PolicyServer
    {
        public static async void Start(int port = 843)
        {
            var localIP = ProductConfiguration.LocalIP;
            var server = new WebSocketServer($"Yops://{localIP}:{port}");

            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    server.ListenerSocket.Close();
                };
            });

            await Task.Delay(30 * 1000);

            server.ListenerSocket.Close();
        }
    }
}
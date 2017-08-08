using Yopon.Flash;
using Yopon.Pigg;
using Yopon.Properties;
using Fleck;
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebSocket4Net;

namespace Yopon.WebSocket
{
    public class TransparentProxy
    {
        private WebSocket4Net.WebSocket client;

        private IWebSocketConnection server;

        public Action<ByteArray> SendHandle;

        public Action<ByteArray> RecvHandle;

        public bool IsActive => server.IsAvailable;

        static TransparentProxy()
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        public TransparentProxy(Action<ByteArray> sendHandle, Action<ByteArray> recvHandle)
        {
            SendHandle = sendHandle ??
                throw new ArgumentNullException();
            RecvHandle = recvHandle ??
                throw new ArgumentNullException();
        }

        public async void Start(int port, string uri)
        {
            var localIP = ProductConfiguration.LocalIP;
            var server = new WebSocketServer($"wss://{localIP}:{port}");

            client = new WebSocket4Net.WebSocket(uri, version: WebSocketVersion.Rfc6455);
            server.Certificate = new X509Certificate2(Resources.RedoCert, "CyberAgent");

            server.Start(socket =>
            {
                this.server = socket;

                socket.OnOpen = () =>
                {
                    server.ListenerSocket.Close();
                    client.AllowUnstrustedCertificate = true;
                    client.DataReceived += (sender, e) =>
                    RecvHandle?.Invoke(new ByteArray(e.Data));
                    client.Closed += (sender, e) => socket.Close();
                    client.Open();
                };

                socket.OnBinary = data =>
                SendHandle?.Invoke(new ByteArray(data));
                socket.OnClose = client.Close;
            });

            await Task.Delay(60 * 1000);
            server.ListenerSocket.Close();
        }

        public void Send(ByteArray message)
        {
            Send(message.Bytes);
        }

        public void Send(byte[] message)
        {
            if (message != null && message.Length > 0)
                client.Send(message, 0, message.Length);
        }

        public void Recv(ByteArray message)
        {
            Recv(message.Bytes);
        }

        public void Recv(byte[] message)
        {
            if (message != null && message.Length > 0)
                server.Send(message);
        }
    }
}
using Yopon.Flash;
using Yopon.WebSocket;

namespace Yopon.Pigg
{
    public interface IPiggProxy
    {
        byte[] Key { get; set; }

        TransparentProxy WebSocketProxy { get; set; }

        void SendHandle(ByteArray data);

        void RecvHandle(ByteArray data);
    }
}
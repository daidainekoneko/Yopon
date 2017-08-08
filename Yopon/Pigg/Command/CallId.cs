using Yopon.Flash;

namespace Yopon.Pigg.Command
{
    public class CallId
    {
        public int Id;

        public int Enc;

        public byte[] Keys()
        {
            var byteArray = new ByteArray();
            byteArray.WriteInt(Enc);
            byteArray.WriteInt(Id);
            return byteArray.Bytes;
        }
    }
}
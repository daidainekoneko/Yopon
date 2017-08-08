using Yopon.Flash;

namespace Yopon.Pigg.Command
{
    public class Header
    {
        public const int TYPE_COMMAND = 16;

        public const int TYPE_COMMAND_ENC = 17;

        public const int TYPE_PING = 511;

        public const int TYPE_ID = 496;

        public const int TYPE_ENC = 497;

        public int Type = TYPE_COMMAND;

        public int CommandId;

        public CallId CallId = new CallId();

        public byte[] Body = new byte[0];

        public int Length => Body.Length;

        public Header()
        {
        }

        public Header(ByteArray byteArray)
        {
            Read(byteArray);
        }

        public void Read(ByteArray byteArray)
        {
            Type = byteArray.ReadShort();

            if (Type == TYPE_ID)
            {
                CallId.Id = byteArray.ReadInt();
                CallId.Enc = byteArray.ReadInt();
            }
            else if (Type == TYPE_COMMAND)
            {
                byteArray.ReadInt();
                CommandId = byteArray.ReadShort();
                var length = byteArray.ReadInt();
                Body = byteArray.ReadBytes(length);
            }

            byteArray.Position = 0;
        }

        public void Write(ByteArray byteArray)
        {
            byteArray.Clear();
            byteArray.WriteShort((short)Type);

            if (Type == TYPE_ID)
            {
                byteArray.WriteInt(CallId.Id);
                byteArray.WriteInt(CallId.Enc);
            }
            else if (Type == TYPE_COMMAND)
            {
                byteArray.WriteInt(0);
                byteArray.WriteShort((short)CommandId);
                byteArray.WriteInt(Length);
                byteArray.WriteBytes(Body);
            }

            byteArray.Position = 0;
        }

        public byte[] ToArray()
        {
            var byteArray = new ByteArray();
            Write(byteArray);
            return byteArray.Bytes;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Yopon.Flash
{
    public static class Converter
    {
        private const int HEADER_SIZE = 8;

        public static KeyValuePair<byte[], byte[]> GetFrame(ByteArray byteArray)
        {
            var header = byteArray.ReadBytes(HEADER_SIZE);
            var body = byteArray.ReadBytes(byteArray.BytesAvailable);
            return new KeyValuePair<byte[], byte[]>(header, body);
        }

        public static byte[] ToFws(byte[] raw)
        {
            return ToFws(new ByteArray(raw));
        }

        public static byte[] ToFws(ByteArray byteArray)
        {
            var frame = GetFrame(byteArray);
            var body = new ByteArray(frame.Value);
            body.Uncompress();
            frame.Key[0] = Convert.ToByte('F');
            return frame.Key.Concat(body.Bytes).ToArray();
        }

        public static byte[] ToCws(byte[] raw)
        {
            return ToCws(new ByteArray(raw));
        }

        public static byte[] ToCws(ByteArray byteArray)
        {
            var frame = GetFrame(byteArray);
            var body = new ByteArray(frame.Value);
            body.Compress();
            frame.Key[0] = Convert.ToByte('C');
            return frame.Key.Concat(body.Bytes).ToArray();
        }
    }
}
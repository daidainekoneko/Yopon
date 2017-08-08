using Yopon.Flash;

namespace Yopon.ModuleLoader
{
    public class D
    {
        private int i;

        private int j;

        private byte[] s;

        public D(ByteArray byteArray) : this(byteArray.Bytes)
        {
        }

        public D(byte[] byteArray)
        {
            s = new byte[256];
            Init(byteArray);
        }

        public void Init(byte[] bytes)
        {
            var i = 0;
            var j = 0;

            for (var k = 0; k < 256; k++)
            {
                s[k] = (byte)k;
            }

            for (var l = 0; l < 256; l++)
            {
                i = i + s[l] + bytes[l % bytes.Length] & 255;
                j = s[l];
                s[l] = s[i];
                s[i] = (byte)j;
            }

            this.i = 0;
            this.j = 0;
        }

        public void Decrypt(byte[] data)
        {
            var i = 0;
            var j = 0;
            var k = data.Length;

            for (var _4 = 0; _4 < k; _4++)
            {
                this.i = this.i + 1 & 255;
                i = s[this.i];
                this.j = this.j + i & 255;
                j = s[this.j];
                s[this.i] = (byte)j;
                s[this.j] = (byte)i;
                data[_4] = (byte)(data[_4] ^ s[i + j & 255]);
            }
        }

        public void DecryptBlock(byte[] data, int index, int block)
        {
            var i = 0;
            var j = 0;
            var k = index + block;

            if (k > data.Length)
            {
                k = data.Length;
            }

            for (var l = index; l < k; l++)
            {
                this.i = this.i + 1 & 255;
                i = s[this.i];
                this.j = this.j + i & 255;
                j = s[this.j];
                s[this.i] = (byte)j;
                s[this.j] = (byte)i;
                data[l] = (byte)(data[l] ^ s[i + j & 255]);
            }
        }
    }
}
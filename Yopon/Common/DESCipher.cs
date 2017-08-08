using System;
using System.Linq;
using System.Security.Cryptography;

namespace Yopon.Common
{
    public class DESCipher
    {
        public static DESCryptoServiceProvider CreateProvider(byte[] key)
        {
            var provider = new DESCryptoServiceProvider();
            provider.Mode = CipherMode.ECB;
            provider.Padding = PaddingMode.PKCS7;
            provider.KeySize = 64;
            provider.Key = key;
            return provider;
        }

        public static byte[] Encrypt(byte[] d, byte[] k)
        {
            using (var provider = CreateProvider(k))
            using (var encryptor = provider.CreateEncryptor())
            {
                return encryptor.TransformFinalBlock(d, 0, d.Length);
            }
        }

        public static byte[] Decrypt(byte[] d, byte[] k)
        {
            using (var provider = CreateProvider(k))
            using (var decryptor = provider.CreateDecryptor())
            {
                return decryptor.TransformFinalBlock(d, 0, d.Length);
            }
        }

        public static bool IsEncryptData(byte[] d, byte[] k)
        {
            try
            {
                var survey = d.Length - 8;

                if (survey < 0)
                    return false;

                Decrypt(d.Skip(survey)
                    .ToArray(), k);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
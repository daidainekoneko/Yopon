using Yopon.Flash;
using Yopon.ModuleLoader;
using Yopon.Pigg;
using CefSharp;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Yopon.CEFHandler
{
    public class PiggModuleResourceHandler : PiggResourceHandler
    {
        private byte[] keyPrefixHash = new byte[] { 11, 110, 125, 93, 4, 65, 3, 237 };

        public override bool ProcessRequestAsync(IRequest request, ICallback callback)
        {
            var url = request.Url;

            Task.Run(() =>
            {
                using (callback)
                {
                    var data = Download(url);

                    if (data.Length > 0)
                    {
                        var module = new ByteArray(data);
                        int signature = module.ReadByte();

                        if (signature == 101)
                        {
                            var keys = new ByteArray();

                            keys.WriteBytes(keyPrefixHash);
                            keys.WriteBytes(module.ReadBytes(8));

                            var position = module.Position;
                            var cipherData = module.ReadBytes(module.Length - position);

                            module.Position = position;

                            var decryptor = new D(keys);
                            var index = 0;

                            while (index + 1024 < cipherData.Length)
                            {
                                decryptor.DecryptBlock(cipherData, index, 32);
                                index = index + 1024;
                            }

                            if (YoponSetting.I.HasDownloadModule)
                            {
                                var dir = YoponSetting.SwfSaveDir;
                                var f = new Uri(url).LocalPath;
                                var name = Path.GetFileName(f);
                                Directory.CreateDirectory(dir);
                                File.WriteAllBytes($"{dir}{name}", cipherData);
                            }

                            AllowActionList.LoadSwf(cipherData);

                            var stream = new MemoryStream(data);

                            ResponseLength = stream.Length;
                            StatusCode = (int)HttpStatusCode.OK;
                            Stream = stream;

                            callback.Continue();
                        }
                    }
                }
            });

            return true;
        }
    }
}
using Yopon.Common;
using Yopon.Flash;
using Yopon.Pigg;
using CefSharp;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Yopon.CEFHandler
{
    public class PiggSwfResourceHandler : PiggResourceHandler
    {
        public override bool ProcessRequestAsync(IRequest request, ICallback callback)
        {
            var url = request.Url;

            Task.Run(() =>
            {
                using (callback)
                {
                    var raw = Download(url);

                    if (raw.Length >= 3 && "CWS" == Encoding.ASCII.GetString(raw.Take(3).ToArray()))
                    {
                        var policyPort = 843;
                        var infoPort = Rand.om(49152, 65535);
                        var info = ProductConfiguration.InfoWebSocketUrl;
                        var compileSwf = DefacingAbc.EditHost(raw, infoPort);
                        var cws = Converter.ToCws(compileSwf);

                        PolicyServer.Start(policyPort);
                        PiggInfoProxy.Start(info, infoPort);

                        var stream = new MemoryStream(cws);
                        ResponseLength = stream.Length;
                        StatusCode = (int)HttpStatusCode.OK;
                        Stream = stream;

                        callback.Continue();
                    }
                }
            });

            return true;
        }
    }
}
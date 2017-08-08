using CefSharp;

namespace Yopon.CEFHandler
{
    public class PiggResourceHandlerFactory : IResourceHandlerFactory
    {
        bool IResourceHandlerFactory.HasHandlers
        {
            get { return true; }
        }

        IResourceHandler IResourceHandlerFactory.GetResourceHandler(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request)
        {
            if (request.Url.Contains("//pigg.ameba.jp/swf/pigg.swf"))
            {
                return new PiggSwfResourceHandler();
            }
            if (request.Url.Contains("//pigg.ameba.jp/swf/content/"))
            {
                return new PiggModuleResourceHandler();
            }
            return null;
        }
    }
}
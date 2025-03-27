using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;

namespace PrøveFagprøve.Business.Services
{
    public class ImageUrlService(UrlResolver urlResolver)
    {
        public string GetImageUrl(ContentReference image)
        {
            if (image != null)
            {
                return urlResolver.GetUrl(image);
            }
            return string.Empty;
        }
    }
}
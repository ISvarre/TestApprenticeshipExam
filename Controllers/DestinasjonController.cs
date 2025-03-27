using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using PrøveFagprøve.Models.Pages;

namespace PrøveFagprøve.Controllers
{
    public class DestinasjonController : Controller
    {
        private readonly UrlResolver _urlResolver;

        // Inject UrlResolver via constructor
        public DestinasjonController(UrlResolver urlResolver)
        {
            _urlResolver = urlResolver;
        }

        public IActionResult Index(Destinasjon currentPage)
        {
            // Resolve the URL for the Image property
            var imageUrl = currentPage.Image != null ? _urlResolver.GetUrl(currentPage.Image) : string.Empty;

            // Pass the resolved URL to the view using ViewBag or a ViewModel
            ViewBag.ImageUrl = imageUrl;

            return View(currentPage);
        }
    }
}
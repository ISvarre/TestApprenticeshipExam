using PrøveFagprøve.Models.Pages;
using PrøveFagprøve.Models.ViewModels;
using EPiServer.Web;
using Microsoft.AspNetCore.Mvc;

namespace PrøveFagprøve.Controllers
{
    public class CulturePageController : PageControllerBase<CulturePage>
    {
        public ViewResult Index(CulturePage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            return View("CulturePage", model);
        }
    }
}
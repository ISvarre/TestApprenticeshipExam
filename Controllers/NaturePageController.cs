using PrøveFagprøve.Models.Pages;
using PrøveFagprøve.Models.ViewModels;
using EPiServer.Web;
using Microsoft.AspNetCore.Mvc;

namespace PrøveFagprøve.Controllers
{
    public class NaturePageController : PageControllerBase<NaturePage>
    {
        public ViewResult Index(NaturePage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            return View("NaturePage", model);
        }
    }
}

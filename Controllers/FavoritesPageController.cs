using PrøveFagprøve.Models.Pages;
using PrøveFagprøve.Models.ViewModels;
using EPiServer.Web;
using Microsoft.AspNetCore.Mvc;

namespace PrøveFagprøve.Controllers
{
    public class FavoritesPageController : PageControllerBase<FavoritesPage>
    {
        public ViewResult Index(FavoritesPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            return View("FavoritesPage", model);
        }
    }
}
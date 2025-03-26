using PrøveFagprøve.Models.Pages;
using PrøveFagprøve.Models.ViewModels;
using EPiServer.Web;
using Microsoft.AspNetCore.Mvc;

namespace PrøveFagprøve.Controllers
{
    public class FoodPageController : PageControllerBase<FoodPage>
    {
        public ViewResult Index(FoodPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            return View("FoodPage", model);
        }
    }
}
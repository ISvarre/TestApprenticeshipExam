using PrøveFagprøve.Models.Pages;
using PrøveFagprøve.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace PrøveFagprøve.Controllers
{
    public class AccommodationPageController : PageControllerBase<AccommodationPage>
    {
        public ViewResult Index(AccommodationPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            return View("AccommodationPage", model);
        }
    }
}
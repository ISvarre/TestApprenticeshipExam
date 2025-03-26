using PrøveFagprøve.Models.Pages;
using PrøveFagprøve.Models.ViewModels;
using EPiServer.Web;
using Microsoft.AspNetCore.Mvc;

namespace PrøveFagprøve.Controllers
{
    public class ActivityPageController : PageControllerBase<ActivityPage>
    {
        public ViewResult Index(ActivityPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            return View("ActivityPage", model);
        }
    }
}
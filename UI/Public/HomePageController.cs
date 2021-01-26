using Microsoft.AspNetCore.Mvc;

namespace Vera.CMS.UI.Public
{
    public class HomePageController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
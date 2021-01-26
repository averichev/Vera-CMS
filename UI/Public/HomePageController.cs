using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vera.CMS.Models.Repository;

namespace Vera.CMS.UI.Public
{
    public class HomePageController : Controller
    {
        private readonly IPageRepository _repository;
        public HomePageController(IPageRepository repository)
        {
            _repository = repository;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            var list = await _repository.List();
            return View(list);
        }
    }
}
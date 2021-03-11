using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vera.CMS.Models.Repository;
using Vera.CMS.UI.Public.Models;

namespace Vera.CMS.UI.Public
{
    public class PagesController : Controller
    {
        private readonly IPageRepository _repository;

        public PagesController(IPageRepository repository)
        {
            _repository = repository;
        }

        [Route("/page-{pageId}/")]
        public async Task<IActionResult> DetailPage(int pageId)
        {
            var page = await _repository.Page(pageId);

            return View(new PageView (page)
            {
                Header = page.Header
            });
        }
    }
}
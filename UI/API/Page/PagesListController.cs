using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vera.CMS.Models.Repository;

namespace Vera.CMS.UI.API.Page
{
    public class PagesListController : Controller
    {
        private readonly IPageRepository _repository;

        public PagesListController(IPageRepository repository)
        {
            _repository = repository;
        }
        
        [Authorize]
        [Route("api/pages")]
        [HttpGet]
        public async Task<IActionResult> PagesList()
        {
            var pages = await _repository.List();
            return new JsonResult(new
            {
                items = pages
            });
        }
    }
}
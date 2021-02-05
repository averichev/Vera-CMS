using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vera.CMS.Models.Repository;

namespace Vera.CMS.UI.API.Page
{
    public class PageInfoController : Controller
    {
        private readonly IPageRepository _repository;

        public PageInfoController(IPageRepository repository)
        {
            _repository = repository;
        }
        
        [Authorize]
        [Route("api/pages/{pageId}")]
        [HttpGet]
        public async Task<IActionResult> PagesList(int pageId)
        {
            var page = await _repository.Page(pageId);
            return new JsonResult(page);
        }
    }
}
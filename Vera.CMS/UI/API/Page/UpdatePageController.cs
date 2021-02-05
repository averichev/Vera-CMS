using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vera.CMS.Application.Services.Page;
using Vera.CMS.Models.Repository;
using Vera.CMS.UI.API.Page.Models;

namespace Vera.CMS.UI.API.Page
{
    public class UpdatePageController : Controller
    {
        private readonly IPageRepository _repository;

        public UpdatePageController(IPageRepository repository)
        {
            _repository = repository;
        }

        [Authorize]
        [Route("api/page/update")]
        [HttpPost]
        public async Task<IActionResult> UpdatePage([FromBody]UpdatedPage updated)
        {
            var creator = new PageCreator(updated);
            await _repository.Update(creator.Get());
            return new JsonResult(true);
        }
    }
}
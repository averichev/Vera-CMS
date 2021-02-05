using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vera.CMS.Application.Services.Page;
using Vera.CMS.Models.Repository;
using Vera.CMS.UI.API.Page.Models;

namespace Vera.CMS.UI.API.Page
{
    public class AddPageController : Controller
    {
        private readonly IPageRepository _repository;

        public AddPageController(IPageRepository repository)
        {
            _repository = repository;
        }

        [Authorize]
        [Route("api/page/add")]
        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> Add([FromBody]CreatedPage createdPage)
        {
            var creator = new PageCreator(createdPage);
            var id = await _repository.Add(creator.Get());
            return new JsonResult(new NewPage(id));
        }
    }
}
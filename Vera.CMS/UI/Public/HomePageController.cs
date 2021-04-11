using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vera.CMS.Application.Services;
using Vera.CMS.Models.Repository;
using Vera.CMS.UI.Public.Models;
using Vera.CMS.UI.Public.Models.Templates;

namespace Vera.CMS.UI.Public
{
    public class HomePageController : Controller
    {
        private readonly IPageRepository _repository;
        private readonly ITemplateRenderer _renderer;

        public HomePageController(IPageRepository repository, ITemplateRenderer renderer)
        {
            _repository = repository;
            _renderer = renderer;
        }

        [Route("/")]
        [Produces("text/html")]
        public async Task<string> Index()
        {
            var list = await _repository.List();
            var dictionary = new Dictionary<string, object>
            {
                {"PageItemList", new PageItemList(list)}, {"Title", "Title of main page"}
            };
            var meta = await _renderer.RenderPartialAsync(new Dictionary<string, object>
            {
                {"Description", "Test meta description"}
            }, "Meta");
            var partials = new Dictionary<string, string>
            {
                {"Meta", meta}
            };
            return await _renderer.RenderAsync(dictionary, partials);
        }
    }
}
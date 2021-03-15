using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Vera.CMS.Application.Services;
using Vera.CMS.Models.Repository;
using Vera.CMS.Models.Sitemap;

namespace Vera.CMS.UI.Public
{
    public class SitemapController : ControllerBase
    {
        private readonly IPageRepository _repository;
        private readonly ISiteRepository _siteRepository;
        private readonly IUrlHelperFactory _factory;

        public SitemapController(IPageRepository repository, ISiteRepository siteRepository, IUrlHelperFactory factory)
        {
            _repository = repository;
            _siteRepository = siteRepository;
            _factory = factory;
        }

        [HttpGet]
        [Route("/sitemap.xml")]
        [Produces("text/xml")]
        public async Task<UrlSet> SitemapXml()
        {
            var pages = await _repository.ListAsync();
            var factory = new SitemapFactory(_siteRepository, _factory.GetUrlHelper(ControllerContext));
            return await factory.BuildSitemapAsync(pages);
        }
    }
}
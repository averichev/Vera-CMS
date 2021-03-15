using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vera.CMS.Models.Entity;
using Vera.CMS.Models.Repository;
using Vera.CMS.Models.Sitemap;

namespace Vera.CMS.Application.Services
{
    public class SitemapFactory
    {
        private readonly ISiteRepository _repository;
        private readonly IUrlHelper _helper;

        public SitemapFactory(ISiteRepository repository, IUrlHelper helper)
        {
            _repository = repository;
            _helper = helper;
        }

        public async Task<UrlSet> BuildSitemapAsync(IEnumerable<IPage> pages)
        {
            var defaultSite = await _repository.GetDefaultSiteAsync();
            var urlSet = new UrlSet();
            var urlList = pages
                .Select(page => _helper
                    .RouteUrl("DetailPage", new {pageId = page.Id})
                )
                .Select(routeUrl => new Url
                {
                    Loc = defaultSite.Protocol + "://" + defaultSite.Host + routeUrl
                })
                .ToList();
            urlList.Add(new Url
            {
                Loc = defaultSite.Protocol + "://" + defaultSite.Host + "/"
            });

            urlSet.Url = urlList;

            return urlSet;
        }
    }
}
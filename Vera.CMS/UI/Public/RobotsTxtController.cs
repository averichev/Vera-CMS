using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vera.CMS.Models.Repository;

namespace Vera.CMS.UI.Public
{
    public class RobotsTxtController : ControllerBase
    {
        private readonly ISiteRepository _repository;

        public RobotsTxtController(ISiteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("/robots.txt")]
        [Produces("text/plain")]
        public async Task<string> RobotsTxt()
        {
            var site = await _repository.GetDefaultSiteAsync();
            return site.RobotsTxt;
        }
    }
}
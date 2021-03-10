using System.Threading.Tasks;
using Vera.CMS.Infrastructure.Database.Entity;

namespace Vera.CMS.Models.Repository
{
    public interface ISiteRepository
    {
        public Task<Site> GetDefaultSiteAsync();
    }
}
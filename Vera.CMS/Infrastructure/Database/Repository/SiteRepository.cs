using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vera.CMS.Infrastructure.Database.Entity;
using Vera.CMS.Models.Repository;

namespace Vera.CMS.Infrastructure.Database.Repository
{
    public class SiteRepository : ISiteRepository
    {
        private readonly DataBaseContext _context;

        public SiteRepository(DataBaseContext context)
        {
            _context = context;
        }

        public Task<Site> GetDefaultSiteAsync()
        {
            return _context.Site
                .OrderByDescending(n => n.Id)
                .FirstOrDefaultAsync();
        }
    }
}
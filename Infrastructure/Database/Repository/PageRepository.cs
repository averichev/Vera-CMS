using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vera.CMS.Infrastructure.Database.Entity;
using Vera.CMS.Models.Repository;

namespace Vera.CMS.Infrastructure.Database.Repository
{
    public class PageRepository : IPageRepository
    {
        private readonly DataBaseContext _context;
        private readonly DbSet<Page> _set;

        public PageRepository(DataBaseContext context)
        {
            _context = context;
            _set = context.Page;
        }

        public async Task<int> Add(Page page)
        {
            var valueTask = await _set.AddAsync(page);
            await _context.SaveChangesAsync();
            return valueTask.Entity.Id;
        }
    }
}
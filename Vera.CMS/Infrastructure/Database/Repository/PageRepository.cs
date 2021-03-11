using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vera.CMS.Infrastructure.Database.Entity;
using Vera.CMS.Models.Entity;
using Vera.CMS.Models.Repository;
using Vera.CMS.Models.Repository.Pages;

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

        public async Task<IEnumerable<PageItem>> List()
        {
            return await _set
                .Select(n => new PageItem
                {
                    Header = n.Header,
                    Id = n.Id
                })
                .OrderByDescending(n => n.Id)
                .ToListAsync();
        }

        public async Task<IPage> Page(int id)
        {
            return await _set.FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<int> Update(Page page)
        {
            _context.Update(page);
            return await _context.SaveChangesAsync();
        }
    }
}
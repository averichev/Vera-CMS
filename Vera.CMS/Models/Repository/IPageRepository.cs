using System.Collections.Generic;
using System.Threading.Tasks;
using Vera.CMS.Infrastructure.Database.Entity;
using Vera.CMS.Models.Entity;
using Vera.CMS.Models.Repository.Pages;

namespace Vera.CMS.Models.Repository
{
    public interface IPageRepository
    {
        Task<int> Add(Page page);
        Task<IEnumerable<PageItem>> List();
        Task<IPage> Page(int id);
        Task<int> Update(Page page);
    }
}
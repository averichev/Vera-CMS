using System.Threading.Tasks;
using Vera.CMS.Infrastructure.Database.Entity;

namespace Vera.CMS.Models.Repository
{
    public interface IPageRepository
    {
        Task<int> Add(Page page);
    }
}
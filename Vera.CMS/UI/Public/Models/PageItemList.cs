using System.Collections.Generic;
using System.Linq;
using Vera.CMS.Models.Repository.Pages;

namespace Vera.CMS.UI.Public.Models
{
    public class PageItemList
    {
        public PageItemList(IEnumerable<PageItem> list)
        {
            List = list;
        }
        public IEnumerable<PageItem> List { get; }
        public bool HasItems => List != null && List.Any();
    }
}

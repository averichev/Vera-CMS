using Newtonsoft.Json;
using Vera.CMS.Models.Entity;

namespace Vera.CMS.UI.Public.Models
{
    public class PageView
    {
        public PageView(IPage page)
        {
            var json = page.Content.ToString();
            Content = JsonConvert.DeserializeObject<PageContent>(json);
        }
        public string Header { get; set; }
        public PageContent Content { get; }
    }
}
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
            if (page.LastUpdateTime != null)
            {
                LastUpdate = page.LastUpdateTime.Value.ToString("dd.MM.yyyy");
            }
        }
        public string Header { get; set; }
        public PageContent Content { get; }
        public string LastUpdate { get; }
        public bool HasLastUpdate => string.IsNullOrEmpty(LastUpdate) == false;
    }
}
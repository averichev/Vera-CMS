using System.Collections.Generic;

namespace Vera.CMS.Models.Sitemap
{
    public class UrlSet
    {
        public UrlSet()
        {
            Url = new List<Url>();
        }

        public List<Url> Url { get; set; }
    }
}
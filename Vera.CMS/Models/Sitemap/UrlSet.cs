using System.Collections.Generic;
using System.Xml.Serialization;

namespace Vera.CMS.Models.Sitemap
{
    [XmlRoot(ElementName = "urlset", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class UrlSet
    {
        public UrlSet()
        {
            Url = new List<Url>();
        }
        [XmlElement(ElementName = "url")]
        public List<Url> Url { get; set; }
    }
}
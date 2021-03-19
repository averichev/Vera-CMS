using System.Xml.Serialization;

namespace Vera.CMS.Models.Sitemap
{
    public class Url
    {
        public Url()
        {
        }

        [XmlElement(ElementName = "loc")]
        public string Loc { get; set; }
    }
}
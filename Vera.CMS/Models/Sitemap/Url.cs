using System;
using System.Xml.Serialization;

namespace Vera.CMS.Models.Sitemap
{
    public class Url
    {
        public Url()
        {
        }

        public Url(DateTime? lastMod)
        {
            if (lastMod != null)
            {
                LastMod = lastMod.Value.ToString("yyyy-MM-dd");
            }
        }

        [XmlElement(ElementName = "loc")]
        public string Loc { get; set; }
        [XmlElement(ElementName = "lastmod")]
        public string LastMod { get; set; }
    }
}
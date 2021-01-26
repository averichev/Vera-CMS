using System.Collections.Generic;
using System.Numerics;

namespace Vera.CMS.UI.Public.Models
{
    public class PageContent
    {
        public BigInteger Time { get; set; }
        public string Version { get; set; }
        public IEnumerable<ContentBlock> Blocks { get; set; }
    }
}
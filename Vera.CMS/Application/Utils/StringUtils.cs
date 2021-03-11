using System.Text.RegularExpressions;

namespace Vera.CMS.Application.Utils
{
    public static class StringUtils
    {
        public static string StripHtml(string input)
        {
            return Regex.Replace(input, "<.*?>", string.Empty);
        }
    }
}
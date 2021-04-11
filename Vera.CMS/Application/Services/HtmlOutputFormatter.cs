using Microsoft.AspNetCore.Mvc.Formatters;

namespace Vera.CMS.Application.Services
{
    public class HtmlOutputFormatter : StringOutputFormatter
    {
        public HtmlOutputFormatter()
        {
            SupportedMediaTypes.Add("text/html");
        }
    }
}
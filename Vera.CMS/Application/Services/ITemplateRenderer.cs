using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vera.CMS.Application.Services
{
    public interface ITemplateRenderer
    {
        public Task<string> RenderAsync(Dictionary<string, object> dictionary);
        public Task<string> RenderAsync(Dictionary<string, object> dictionary, Dictionary<string, string> partials);
        public Task<string> RenderPartialAsync(Dictionary<string, object> dictionary, string template);
    }
}
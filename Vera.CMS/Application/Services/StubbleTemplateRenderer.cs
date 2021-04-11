using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Stubble.Core;
using Stubble.Core.Builders;
using Stubble.Extensions.JsonNet;

namespace Vera.CMS.Application.Services
{
    public class StubbleTemplateRenderer : ITemplateRenderer
    {
        private readonly StubbleVisitorRenderer _renderer;

        public StubbleTemplateRenderer()
        {
            _renderer = new StubbleBuilder()
                .Configure(settings =>
                {
                    settings.SetIgnoreCaseOnKeyLookup(true);
                    settings.SetMaxRecursionDepth(512);
                    settings.AddJsonNet(); // Extension method from extension library
                })
                .Build();
        }

        public async Task<string> RenderAsync(Dictionary<string, object> dictionary)
        {
            var content = await ReadTemplate("layout");
            var output = await _renderer.RenderAsync(content, dictionary);
            return output;
        }
        
        public async Task<string> RenderAsync(Dictionary<string, object> dictionary,
            Dictionary<string, string> partials)
        {
            var content = await ReadTemplate("layout");
            return await _renderer.RenderAsync(content, dictionary, partials);
        }

        public async Task<string> RenderPartialAsync(Dictionary<string, object> dictionary, string template)
        {
            var content = await ReadTemplate(template);
            return await _renderer.RenderAsync(content, dictionary);
        }

        private static async Task<string> ReadTemplate(string path)
        {
            var template = Path(path);
            using var streamReader = new StreamReader(template, Encoding.UTF8);
            return await streamReader.ReadToEndAsync();
        }

        private static string Path(string path)
        {
            return @"./Templates/" + path + ".mustache";
        }
    }
}
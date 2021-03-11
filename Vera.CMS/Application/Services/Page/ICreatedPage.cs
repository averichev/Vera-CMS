using System.Text.Json;

namespace Vera.CMS.Application.Services.Page
{
    public interface ICreatedPage
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public JsonElement Content { get; set; }
    }
}
using System.Text.Json;
using Vera.CMS.Application.Services.Page;

namespace Vera.CMS.UI.API.Page.Models
{
    public class CreatedPage : ICreatedPage
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public JsonElement Content { get; set; }
    }
}
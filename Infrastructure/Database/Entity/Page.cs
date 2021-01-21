using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Vera.CMS.Models.Entity;

namespace Vera.CMS.Infrastructure.Database.Entity
{
    public class Page : IPage
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public JsonElement Content { get; set; }
    }
}
using System;
using System.Text.Json;

namespace Vera.CMS.Models.Entity
{
    public interface IPage
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public JsonElement Content { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}
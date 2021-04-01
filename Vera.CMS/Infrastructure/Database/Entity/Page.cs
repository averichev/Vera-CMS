using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Vera.CMS.Models.Entity;

namespace Vera.CMS.Infrastructure.Database.Entity
{
    public class Page : IPage
    {
        public Page()
        {
            LastUpdateTime = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public JsonElement Content { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}
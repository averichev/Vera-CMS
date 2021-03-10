using System.ComponentModel.DataAnnotations;
using Vera.CMS.Models.Entity;

namespace Vera.CMS.Infrastructure.Database.Entity
{
    public class Site : ISite
    {
        [Key]
        public int Id { get; set; }
        public string Protocol { get; set; }
        public string Host { get; set; }
        public string RobotsTxt { get; set; }
    }
}
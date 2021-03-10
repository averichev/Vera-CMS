namespace Vera.CMS.Models.Entity
{
    public interface ISite
    {
        public int Id { get; set; }
        public string Protocol { get; set; }
        public string Host { get; set; }
        public string RobotsTxt { get; set; }
    }
}
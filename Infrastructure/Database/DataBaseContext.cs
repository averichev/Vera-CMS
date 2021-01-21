using Microsoft.EntityFrameworkCore;
using Vera.CMS.Infrastructure.Database.Entity;

namespace Vera.CMS.Infrastructure.Database
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        
        public DbSet<Page> Page { get; set; }
    }
}
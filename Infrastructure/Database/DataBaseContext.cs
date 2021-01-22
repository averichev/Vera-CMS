using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Vera.CMS.Infrastructure.Database.Entity;

namespace Vera.CMS.Infrastructure.Database
{
    public class DataBaseContext : ApiAuthorizationDbContext<User>
    {
        public DataBaseContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        
        public DbSet<Page> Page { get; set; }
    }
}
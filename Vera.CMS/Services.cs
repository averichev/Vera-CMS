using Microsoft.Extensions.DependencyInjection;
using Vera.CMS.Application.Services;
using Vera.CMS.Infrastructure.Database.Repository;
using Vera.CMS.Models.Repository;

namespace Vera.CMS
{
    public static class Services
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPageRepository, PageRepository>();
            services.AddScoped<ISiteRepository, SiteRepository>();
            services.AddScoped<ITemplateRenderer, StubbleTemplateRenderer>();
        }
    }
}
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Kamrad.Multimedia.EntityFrameworkCore
{
    [DependsOn(
        typeof(MultimediaEntityFrameworkCoreModule)
        )]
    public class MultimediaEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MultimediaMigrationsDbContext>();
        }
    }
}

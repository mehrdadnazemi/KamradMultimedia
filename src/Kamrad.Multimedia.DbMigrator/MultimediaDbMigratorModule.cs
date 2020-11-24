using Kamrad.Multimedia.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Kamrad.Multimedia.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MultimediaEntityFrameworkCoreDbMigrationsModule),
        typeof(MultimediaApplicationContractsModule)
        )]
    public class MultimediaDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

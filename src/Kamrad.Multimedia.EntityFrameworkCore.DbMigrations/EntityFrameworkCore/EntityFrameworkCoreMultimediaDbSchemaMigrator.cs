using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Kamrad.Multimedia.Data;
using Volo.Abp.DependencyInjection;

namespace Kamrad.Multimedia.EntityFrameworkCore
{
    public class EntityFrameworkCoreMultimediaDbSchemaMigrator
        : IMultimediaDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMultimediaDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MultimediaMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MultimediaMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Kamrad.Multimedia.Data
{
    /* This is used if database provider does't define
     * IMultimediaDbSchemaMigrator implementation.
     */
    public class NullMultimediaDbSchemaMigrator : IMultimediaDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
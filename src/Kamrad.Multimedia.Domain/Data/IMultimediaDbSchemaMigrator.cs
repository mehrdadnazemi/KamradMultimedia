using System.Threading.Tasks;

namespace Kamrad.Multimedia.Data
{
    public interface IMultimediaDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

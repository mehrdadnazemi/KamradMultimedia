using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Kamrad.Multimedia.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class MultimediaMigrationsDbContextFactory : IDesignTimeDbContextFactory<MultimediaMigrationsDbContext>
    {
        public MultimediaMigrationsDbContext CreateDbContext(string[] args)
        {
            MultimediaEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MultimediaMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new MultimediaMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Kamrad.Multimedia.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

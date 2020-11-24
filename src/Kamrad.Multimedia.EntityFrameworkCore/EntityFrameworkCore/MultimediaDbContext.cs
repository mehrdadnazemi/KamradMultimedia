using Microsoft.EntityFrameworkCore;
using Kamrad.Multimedia.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
using Kamrad.Multimedia.Files;
using Kamrad.Multimedia.Medias;

namespace Kamrad.Multimedia.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See MultimediaMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class MultimediaDbContext : AbpDbContext<MultimediaDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside MultimediaDbContextModelCreatingExtensions.ConfigureMultimedia
         */
        public DbSet<AppFile> Files { get; set; }
        public DbSet<FileCategories> FileCategories { get; set; }
        public DbSet<FileComments> FileComments { get; set; }
        public DbSet<FileTypes> FileTypes { get; set; }
        public DbSet<FileUserLike> FileUserLikes { get; set; }

        public DbSet<Events> Events { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<MediaInfoFileParticipants> MediaInfoFileParticipants { get; set; }
        public DbSet<MediaInfos> MediaInfos { get; set; }
        public DbSet<OrganizationalMatters> OrganizationalMatters { get; set; }
        public DbSet<OrganizationalPositions> OrganizationalPositions { get; set; }
        public DbSet<Participants> Participants { get; set; }
        public DbSet<ThematicCategories> ThematicCategories { get; set; }


        public MultimediaDbContext(DbContextOptions<MultimediaDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the MultimediaEfCoreEntityExtensionMappings class
                 */
            });

            builder.Entity<AppFile>(b =>
            {
                b.ToTable("Files");
            });

            /* Configure your own tables/entities inside the ConfigureMultimedia method */

            builder.ConfigureMultimedia();
        }
    }
}

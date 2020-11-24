using Kamrad.Multimedia.Files;
using Kamrad.Multimedia.Medias;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Kamrad.Multimedia.EntityFrameworkCore
{
    public static class MultimediaDbContextModelCreatingExtensions
    {
        public static void ConfigureMultimedia(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<AppFile>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + "Files",
                          MultimediaConsts.DbFileSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<FileCategories>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(FileCategories),
                          MultimediaConsts.DbFileSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<FileComments>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(FileComments),
                          MultimediaConsts.DbFileSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<FileTypes>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(FileTypes),
                          MultimediaConsts.DbFileSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<FileUserLikes>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(FileUserLikes),
                          MultimediaConsts.DbFileSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<Genres>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(Genres),
                          MultimediaConsts.DbMediaSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<MediaEvents>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(MediaEvents),
                          MultimediaConsts.DbMediaSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<MediaInfoFileParticipants>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(MediaInfoFileParticipants),
                          MultimediaConsts.DbMediaSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<MediaInfos>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(MediaInfos),
                          MultimediaConsts.DbMediaSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<OrganizationalMatters>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(OrganizationalMatters),
                          MultimediaConsts.DbMediaSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<OrganizationalPositions>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(OrganizationalPositions),
                          MultimediaConsts.DbMediaSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<Participants>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(Participants),
                          MultimediaConsts.DbMediaSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<ThematicCategories>(b =>
            {
                b.ToTable(MultimediaConsts.DbTablePrefix + nameof(ThematicCategories),
                          MultimediaConsts.DbMediaSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });
        }
    }
}
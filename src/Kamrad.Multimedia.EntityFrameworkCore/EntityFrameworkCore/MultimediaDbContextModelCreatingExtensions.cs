using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Kamrad.Multimedia.EntityFrameworkCore
{
    public static class MultimediaDbContextModelCreatingExtensions
    {
        public static void ConfigureMultimedia(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MultimediaConsts.DbTablePrefix + "YourEntities", MultimediaConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
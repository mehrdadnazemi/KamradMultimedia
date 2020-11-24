using Kamrad.Multimedia.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Kamrad.Multimedia
{
    [DependsOn(
        typeof(MultimediaEntityFrameworkCoreTestModule)
        )]
    public class MultimediaDomainTestModule : AbpModule
    {

    }
}
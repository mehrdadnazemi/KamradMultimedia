using Volo.Abp.Modularity;

namespace Kamrad.Multimedia
{
    [DependsOn(
        typeof(MultimediaApplicationModule),
        typeof(MultimediaDomainTestModule)
        )]
    public class MultimediaApplicationTestModule : AbpModule
    {

    }
}
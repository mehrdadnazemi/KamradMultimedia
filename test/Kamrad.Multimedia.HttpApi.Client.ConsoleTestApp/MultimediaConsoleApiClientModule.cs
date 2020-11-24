using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Kamrad.Multimedia.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(MultimediaHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MultimediaConsoleApiClientModule : AbpModule
    {
        
    }
}

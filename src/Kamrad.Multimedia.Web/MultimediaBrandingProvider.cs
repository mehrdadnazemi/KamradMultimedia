using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Kamrad.Multimedia.Web
{
    [Dependency(ReplaceServices = true)]
    public class MultimediaBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Multimedia";
    }
}

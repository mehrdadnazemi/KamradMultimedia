using Kamrad.Multimedia.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Kamrad.Multimedia.Web.Pages
{
    public abstract class MultimediaPageModel : AbpPageModel
    {
        protected MultimediaPageModel()
        {
            LocalizationResourceType = typeof(MultimediaResource);
        }
    }
}
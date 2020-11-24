using Kamrad.Multimedia.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kamrad.Multimedia.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MultimediaController : AbpController
    {
        protected MultimediaController()
        {
            LocalizationResource = typeof(MultimediaResource);
        }
    }
}
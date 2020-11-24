using System;
using System.Collections.Generic;
using System.Text;
using Kamrad.Multimedia.Localization;
using Volo.Abp.Application.Services;

namespace Kamrad.Multimedia
{
    /* Inherit your application services from this class.
     */
    public abstract class MultimediaAppService : ApplicationService
    {
        protected MultimediaAppService()
        {
            LocalizationResource = typeof(MultimediaResource);
        }
    }
}

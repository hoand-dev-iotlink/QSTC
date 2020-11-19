using IOT.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IOT.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class IOTController : AbpController
    {
        protected IOTController()
        {
            LocalizationResource = typeof(IOTResource);
        }
    }
}
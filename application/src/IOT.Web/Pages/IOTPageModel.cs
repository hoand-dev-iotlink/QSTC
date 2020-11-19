using IOT.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace IOT.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class IOTPageModel : AbpPageModel
    {
        protected IOTPageModel()
        {
            LocalizationResourceType = typeof(IOTResource);
        }
    }
}
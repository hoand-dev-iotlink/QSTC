using IOT.Map.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace IOT.Map.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MapPageModel : AbpPageModel
    {
        protected MapPageModel()
        {
            LocalizationResourceType = typeof(MapResource);
            ObjectMapperContext = typeof(MapWebModule);
        }
    }
}
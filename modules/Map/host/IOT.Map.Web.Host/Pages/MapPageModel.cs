using IOT.Map.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace IOT.Map.Pages
{
    public abstract class MapPageModel : AbpPageModel
    {
        protected MapPageModel()
        {
            LocalizationResourceType = typeof(MapResource);
        }
    }
}
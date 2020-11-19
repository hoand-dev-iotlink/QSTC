using IOT.Map.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IOT.Map
{
    public abstract class MapController : AbpController
    {
        protected MapController()
        {
            LocalizationResource = typeof(MapResource);
        }
    }
}

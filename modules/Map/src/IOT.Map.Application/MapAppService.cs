using IOT.Map.Localization;
using Volo.Abp.Application.Services;

namespace IOT.Map
{
    public abstract class MapAppService : ApplicationService
    {
        protected MapAppService()
        {
            LocalizationResource = typeof(MapResource);
            ObjectMapperContext = typeof(MapApplicationModule);
        }
    }
}

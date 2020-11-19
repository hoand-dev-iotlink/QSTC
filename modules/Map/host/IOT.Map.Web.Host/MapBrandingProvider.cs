using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace IOT.Map
{
    [Dependency(ReplaceServices = true)]
    public class MapBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Map";
    }
}

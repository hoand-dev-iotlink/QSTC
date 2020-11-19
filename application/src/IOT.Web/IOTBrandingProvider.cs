using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace IOT.Web
{
    [Dependency(ReplaceServices = true)]
    public class IOTBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "IOT";
    }
}

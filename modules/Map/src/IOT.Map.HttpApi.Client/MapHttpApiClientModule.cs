using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace IOT.Map
{
    [DependsOn(
        typeof(MapApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class MapHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Map";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(MapApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}

using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace IOT.Map
{
    [DependsOn(
        typeof(MapDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class MapApplicationContractsModule : AbpModule
    {

    }
}

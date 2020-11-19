using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace IOT.Map
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(MapDomainSharedModule)
    )]
    public class MapDomainModule : AbpModule
    {

    }
}

using IOT.Map.MongoDB;
using IOT.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace IOT.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(IOTMongoDbModule),
        typeof(IOTApplicationContractsModule),
        typeof(MapMongoDbModule)
        )]
    public class IOTDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

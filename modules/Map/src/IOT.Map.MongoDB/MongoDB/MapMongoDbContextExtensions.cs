using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace IOT.Map.MongoDB
{
    public static class MapMongoDbContextExtensions
    {
        public static void ConfigureMap(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new MapMongoModelBuilderConfigurationOptions(
                MapDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}
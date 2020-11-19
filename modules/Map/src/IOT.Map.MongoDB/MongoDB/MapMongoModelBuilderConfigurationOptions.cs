using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace IOT.Map.MongoDB
{
    public class MapMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public MapMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}
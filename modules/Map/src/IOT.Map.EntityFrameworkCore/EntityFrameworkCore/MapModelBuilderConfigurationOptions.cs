using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace IOT.Map.EntityFrameworkCore
{
    public class MapModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public MapModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}
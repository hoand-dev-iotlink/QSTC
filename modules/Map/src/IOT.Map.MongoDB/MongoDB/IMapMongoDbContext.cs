using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace IOT.Map.MongoDB
{
    [ConnectionStringName(MapDbProperties.ConnectionStringName)]
    public interface IMapMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}

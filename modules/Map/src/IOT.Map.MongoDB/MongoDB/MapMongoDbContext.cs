using IOT.Map.InforMaps;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace IOT.Map.MongoDB
{
    [ConnectionStringName("Default")]
    public class MapMongoDbContext : AbpMongoDbContext, IMapMongoDbContext
    {
        public IMongoCollection<InforMap> InforMaps => Collection<InforMap>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureMap();
        }
    }
}
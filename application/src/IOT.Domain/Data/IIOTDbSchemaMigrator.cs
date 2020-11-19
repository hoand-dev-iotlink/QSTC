using System.Threading.Tasks;

namespace IOT.Data
{
    public interface IIOTDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

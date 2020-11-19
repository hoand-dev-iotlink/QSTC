using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace IOT.Data
{
    /* This is used if database provider does't define
     * IIOTDbSchemaMigrator implementation.
     */
    public class NullIOTDbSchemaMigrator : IIOTDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
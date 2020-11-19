using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace IOT.Map.EntityFrameworkCore
{
    [ConnectionStringName(MapDbProperties.ConnectionStringName)]
    public interface IMapDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}
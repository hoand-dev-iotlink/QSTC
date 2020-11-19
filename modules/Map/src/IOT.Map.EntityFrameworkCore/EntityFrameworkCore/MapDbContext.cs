using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace IOT.Map.EntityFrameworkCore
{
    [ConnectionStringName(MapDbProperties.ConnectionStringName)]
    public class MapDbContext : AbpDbContext<MapDbContext>, IMapDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public MapDbContext(DbContextOptions<MapDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureMap();
        }
    }
}
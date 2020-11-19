using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IOT.Map.EntityFrameworkCore
{
    public class MapHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<MapHttpApiHostMigrationsDbContext>
    {
        public MapHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MapHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Map"));

            return new MapHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

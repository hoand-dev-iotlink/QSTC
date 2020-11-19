using MongoDB.Driver;
using IOT.Users;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;
using IOT.Books;

namespace IOT.MongoDB
{
    [ConnectionStringName("Default")]
    public class IOTMongoDbContext : AbpMongoDbContext
    {
        public IMongoCollection<Book> Books => Collection<Book>();
        public IMongoCollection<AppUser> Users => Collection<AppUser>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.Entity<AppUser>(b =>
            {
                /* Sharing the same "AbpUsers" collection
                 * with the Identity module's IdentityUser class. */
                b.CollectionName = "AbpUsers";
            });
        }
    }
}

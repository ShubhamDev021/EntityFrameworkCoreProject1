using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreProject1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //To inform DB Context to use the table in Entity Framework Core, use DbSet property as below
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
    }
}

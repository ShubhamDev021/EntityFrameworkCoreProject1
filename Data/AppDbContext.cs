using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreProject1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}

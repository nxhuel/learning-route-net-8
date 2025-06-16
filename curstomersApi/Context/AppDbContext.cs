using curstomersApi.Persistence.Entitiy;
using Microsoft.EntityFrameworkCore;

namespace curstomersApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}

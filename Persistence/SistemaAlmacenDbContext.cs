using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class SistemaAlmacenDbContext : DbContext
    {
        public SistemaAlmacenDbContext(DbContextOptions<SistemaAlmacenDbContext> options)
        : base(options)
        { }

        public DbSet<Active> Actives { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Output> Outputs { get; set; }
    }
}
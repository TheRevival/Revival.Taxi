using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class TaxiDbContext : DbContext
    {
        public TaxiDbContext(DbContextOptions options)
            : base(options) { }
      
        public DbSet<Client> Clients { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        
        public DbSet<Transport> Transports { get; set; }
        public  DbSet<TransportType> TransportClasses { get; set; }
        
        public DbSet<Order> Orders { get; set; }
    }
}
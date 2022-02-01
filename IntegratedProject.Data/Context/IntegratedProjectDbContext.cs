using IntegratedProject.Business.Customer.Models;
using IntegratedProject.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace IntegratedProject.Data.Context
{
    public class IntegratedProjectDbContext : DbContext
    {
        public IntegratedProjectDbContext(DbContextOptions<IntegratedProjectDbContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Technical> Technicals { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}

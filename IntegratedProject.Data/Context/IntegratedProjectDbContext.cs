using IntegratedProject.Business.Customer.Models;
using Microsoft.EntityFrameworkCore;

namespace IntegratedProject.Data.Context
{
    public class IntegratedProjectDbContext : DbContext
    {
        public IntegratedProjectDbContext(DbContextOptions<IntegratedProjectDbContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}

using CashCrusaders.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CashCrusaders.Data
{
    public class Storage : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Supplier> Supplier { get; set; } = null!;
        public Storage(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

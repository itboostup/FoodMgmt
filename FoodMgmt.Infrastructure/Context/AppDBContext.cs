using FoodMgmt.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace FoodMgmt.Infrastructure.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> option):base(option)
        { 
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}

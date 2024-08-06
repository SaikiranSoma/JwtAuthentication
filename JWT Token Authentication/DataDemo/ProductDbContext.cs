using JWT_Token_Authentication.ModelDemo;
using Microsoft.EntityFrameworkCore;

namespace JWT_Token_Authentication.DataDemo
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> products { get; set; }
    }
}

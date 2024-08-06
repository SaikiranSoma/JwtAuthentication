using JWT_Token_Authentication.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT_Token_Authentication.Data
{
	public class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
    {
		public DbSet<Product> Products { get; set; }
    }
}

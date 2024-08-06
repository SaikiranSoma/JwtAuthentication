using JWT_Token_Authentication.DataDemo;
using JWT_Token_Authentication.Models;

namespace JWT_Token_Authentication.RepositoryDemo
{
    public class Productservices(ProductDbContext context) : IProduct
    {
        private readonly ProductDbContext _context = context;

		public Product CreateProduct(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return product;
        }

		public IEnumerable<Product> GetAllProducts() => _context.products.ToList();
	}
}

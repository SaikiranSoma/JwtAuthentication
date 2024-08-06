using JWT_Token_Authentication.Data;
using JWT_Token_Authentication.Models;

namespace JWT_Token_Authentication.RepositoryDemo
{
    public class Productservices : IProduct
    {
        private readonly ProductDbContext _context;
        public Productservices(ProductDbContext context)
        {
            _context = context;
        }
        public Product CreateProduct(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.products.ToList();
        }
    }
}

using JWT_Token_Authentication.Models;

namespace JWT_Token_Authentication.RepositoryDemo
{
    public interface IProduct
    {
        public IEnumerable<Product> GetAllProducts();
        public Product CreateProduct(Product product);

    }
}

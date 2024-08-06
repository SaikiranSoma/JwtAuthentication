using JWT_Token_Authentication.ModelDemo;
using JWT_Token_Authentication.RepositoryDemo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Token_Authentication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IProduct _product;
        public DemoController(IProduct product)
        {
            _product = product;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_product.GetAllProducts());
        }

        [HttpPost]
        public IActionResult CreateProducts([FromBody] Product product)
        {
            _product.CreateProduct(product);
            return Ok("Product Created Succesfully");
        }
    }
}

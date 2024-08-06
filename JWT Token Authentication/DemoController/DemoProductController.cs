﻿using JWT_Token_Authentication.Models;
using JWT_Token_Authentication.RepositoryDemo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Token_Authentication.DemoController
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DemoProductController(IProduct product) : ControllerBase
    {
        private readonly IProduct _product = product;

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
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.API.Data;
using Shopping.API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductContext.Products;
            //var rnd = new Random();
            //return Enumerable.Range(1,5).Select(index=>new Product
            //{
            //    Name = "asd"
            //}).ToArray();
        }
    }
}

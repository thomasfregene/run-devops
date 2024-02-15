using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductContext _productContext;

        public ProductController(ILogger<ProductController> logger, ProductContext productContext)
        {
            _logger = logger;
            _productContext = productContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            var result = new List<Product>();
            try
            {
               result = await _productContext
              .Products
              .Find(p => true)
              .ToListAsync();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message);
            }

            return result;
        }
    }
}

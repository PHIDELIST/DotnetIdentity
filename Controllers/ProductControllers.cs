using Microsoft.AspNetCore.Mvc;
using backend.Services.ProductService;
using backend.Models.Dtos;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<GetProducts>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }
        [Authorize( Roles = "Administrator")]
        [HttpPost]
        [HttpGet("{productId}")]
        public async Task<ActionResult<GetProduct>> GetProduct(long productId)
        {
            var result = await _productService.GetProductAsync(productId);

            if (result == null)
            {
                return NotFound(); 
            }

            return Ok(result);
        }
    }
}

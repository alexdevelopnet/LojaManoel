using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data.ValueObjects;
using ProductAPI.Repository;

namespace ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProdutoController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoVO>>> FindAll()
        {
            var products = await _productRepository.FindAll();
            return Ok(products);
        }
    }
}

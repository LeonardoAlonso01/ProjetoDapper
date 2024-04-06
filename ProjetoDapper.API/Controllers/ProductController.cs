using Microsoft.AspNetCore.Mvc;
using ProjetoDapper.Application.Services.Interfaces;
using ProjetoDapper.Core.Entities;

namespace ProjetoDapper.API.Controllers
{
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _service.GetAll();
            return Ok(products);    
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            await _service.AddProctuct(product);
            return Ok(product);
        }
    }
}

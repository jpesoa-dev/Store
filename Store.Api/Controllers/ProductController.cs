using Microsoft.AspNetCore.Mvc;
using Store.Service;

namespace Store.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductService _productService;

    public ProductController(ProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(_productService.GetProducts());
    }

    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        return Ok(new { Message = $"Producto {id}" });
    }

    [HttpPost]
    public IActionResult CreateProduct([FromBody] object product)
    {
        return Ok(new { Message = "Producto creado" });
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, [FromBody] object product)
    {
        return Ok(new { Message = $"Producto {id} actualizado" });
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        return Ok(new { Message = $"Producto {id} eliminado" });
    }
}

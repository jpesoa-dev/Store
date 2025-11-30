using Microsoft.AspNetCore.Mvc;
using Store.Service;

namespace Store.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly CustomerService _customerService;

    public CustomerController(CustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public IActionResult GetCustomers()
    {
        return Ok(_customerService.GetCustomers());
    }

    [HttpGet("{id}")]
    public IActionResult GetCustomer(int id)
    {
        return Ok(new { Message = $"Cliente {id}" });
    }

    [HttpPost]
    public IActionResult CreateCustomer([FromBody] object Customer)
    {
        return Ok(new { Message = "Cliente creado" });
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCustomer(int id, [FromBody] object Customer)
    {
        return Ok(new { Message = $"Cliente {id} actualizado" });
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCustomer(int id)
    {
        return Ok(new { Message = $"Cliente {id} eliminado" });
    }
}

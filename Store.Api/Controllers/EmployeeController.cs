using Microsoft.AspNetCore.Mvc;
using Store.Service;

namespace Store.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly EmployeeService _employeeService;

    public EmployeeController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public IActionResult GetEmployees()
    {
        return Ok(_employeeService.GetEmployees());
    }

    [HttpGet("{id}")]
    public IActionResult GetEmployee(int id)
    {
        return Ok(new { Message = $"Empleado {id}" });
    }

    [HttpPost]
    public IActionResult CreateEmployee([FromBody] object Employee)
    {
        return Ok(new { Message = "Empleado creado" });
    }

    [HttpPut("{id}")]
    public IActionResult UpdateEmployee(int id, [FromBody] object Employee)
    {
        return Ok(new { Message = $"Empleado {id} actualizado" });
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteEmployee(int id)
    {
        return Ok(new { Message = $"Empleado {id} eliminado" });
    }
}

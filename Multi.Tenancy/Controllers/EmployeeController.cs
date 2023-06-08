using Microsoft.AspNetCore.Mvc;
using Multi.Tenancy.Dtos;
using Multi.Tenancy.Entities;
using Multi.Tenancy.Services;

namespace Multi.Tenancy.Controllers
{
    [Route("api/Employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
         }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var employees = await _employeeService.GetAllAsync();

            return Ok(employees);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);

            return employee is null ? NotFound() : Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> CreatedAsync(EmployeeDto dto)
        {
            Employee employee = new()
            {
                Name = dto.Name,
                Description = dto.Description,
             };

            var createdEmployee = await _employeeService.CreatedAsync(employee);

            return Ok(createdEmployee);
        }
    }
}

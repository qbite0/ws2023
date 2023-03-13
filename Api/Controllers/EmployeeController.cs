using Api.Data;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public EmployeeController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(await _databaseContext.Employees.ToListAsync());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetEmployees([FromRoute] Guid id)
        {
            var employee = await _databaseContext.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(AddEmployeeResponse addEmployeeResponse)
        {
            var employee = addEmployeeResponse.ToEmployee();

            await _databaseContext.Employees.AddAsync(employee);
            await _databaseContext.SaveChangesAsync();

            return Ok(employee);
        }
    }
}

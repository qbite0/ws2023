using Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers {
    [ApiController]
    [Route("/api/[controller]")]
    public class EmployeeController : Controller {
        private readonly DatabaseContext _databaseContext;

        public EmployeeController(DatabaseContext databaseContext) {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees() {
            return Ok(await _databaseContext.Employees.ToListAsync());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetEmployees([FromRoute] Guid id) {
            return Ok(await _databaseContext.Employees.FindAsync(id));
        }

    }
}

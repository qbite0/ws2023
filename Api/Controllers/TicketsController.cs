using Api.Data;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : Controller {
        private readonly DatabaseContext _databaseContext;

        public TicketsController(DatabaseContext databaseContext) {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetTickets() {
            return Ok(await _databaseContext.Tickets.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddTicket(AddTicketResponse addTicketDTO) {
            var ticket = addTicketDTO.ToTicket();

            await _databaseContext.Tickets.AddAsync(ticket);
            await _databaseContext.SaveChangesAsync();

            return Ok(ticket);
        }
    }
}

using EntryControl.API.Data;
using EntryControl.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntryControl.API.Controllers
{
    [ApiController]
    [Route("/api/tickets")]
    public class TicketsController : ControllerBase
    {
        private readonly DataContext _context;

        public TicketsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id) 
        {
            var ticket = await _context.Tickets
                .FirstOrDefaultAsync(x => x.Id == id);
            if (ticket == null)
            {
                return BadRequest("Boleta no válida");
            }

            return Ok(ticket);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Ticket ticket)
        {
            try
            {
                _context.Update(ticket);
                await _context.SaveChangesAsync();
                return Ok(ticket);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}

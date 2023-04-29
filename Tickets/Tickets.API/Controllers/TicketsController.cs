using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.API.Data;
using Ticktets.Shared.Entities;

namespace Tickets.API.Controllers
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

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Tickets.ToListAsync());
        }

        [HttpGet("{TicketId}")]
        public async Task<ActionResult> Get(string ticketId)
        {
            var ticket = await _context.Tickets.FirstOrDefaultAsync(x => x.TicketID == ticketId);
            if (ticket == null)
            {
                return NotFound();
            }
            return Ok(ticket);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Ticket ticket)
        {
            _context.Update(ticket);
            try
            {
                await _context.SaveChangesAsync();
                return Ok(ticket);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un registro con el mismo nombre.");
                }
                else
                {
                    return BadRequest(dbUpdateException.InnerException.Message);
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }



        }



    }
}

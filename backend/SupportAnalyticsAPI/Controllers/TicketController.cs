using Microsoft.AspNetCore.Mvc;
using SupportAnalyticsAPI.Models;

namespace SupportAnalyticsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : Controller
    {
        static List<Ticket> tickets=new List<Ticket>()
        {
            new Ticket{
                Id=1,
                CustomerName="John",
                Issue="Login error",
                Status="Open",
                CreatedAt=DateTime.Now
            },
            new Ticket{
                Id=2,
                CustomerName="Sara",
                Issue="Payment failed",
                Status="Closed",
                CreatedAt=DateTime.Now
            }
        };

        [HttpGet]
        public IActionResult GetTickets()
        {
            return Ok(tickets);
        }

        [HttpPost]

        public IActionResult CreateTicket(Ticket ticket)
        {
            tickets.Add(ticket);
            return Ok(ticket);
        }
    }
}
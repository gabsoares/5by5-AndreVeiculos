
using Models;
using Services;

namespace Controllers
{
    public class TicketController
    {
        private TicketService _ticketService;

        public TicketController()
        {
            _ticketService = new TicketService();
        }

        public int InsertTicket(Ticket ticket)
        {
            return _ticketService.InsertTicket(ticket);
        }
    }
}

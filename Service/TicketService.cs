using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class TicketService
    {
        private ITicketRepository _ticketRepository;

        public TicketService()
        {
            _ticketRepository = new TicketRepository();
        }

        public int InsertTicket(Ticket ticket)
        {
            return _ticketRepository.InsertTicket(ticket);
        }
    }
}

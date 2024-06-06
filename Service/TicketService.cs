using Models;
using Repositories;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TicketService
    {
        private ITicketRepository _ticketRepository;

        public TicketService()
        {
            _ticketRepository = new TicketRepository();
        }

        public bool InsertTicket(Ticket ticket)
        {
            return _ticketRepository.InsertTicket(ticket);
        }
    }
}

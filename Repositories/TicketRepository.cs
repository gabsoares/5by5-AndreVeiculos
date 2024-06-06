using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;
using System.Data;

namespace Repositories
{
    public class TicketRepository : ITicketRepository
    {

        private string Conn;

        public TicketRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertTicket(Ticket ticket)
        {
            bool status = false;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(Ticket.INSERT, new
                    {
                        TNumber = ticket.Number,
                        ExpDate = ticket.ExpirationDate
                    });
                    db.Close();
                }
                status = true;
            }
            catch (Exception)
            {
                throw;
            }
            return status;
        }
    }
}

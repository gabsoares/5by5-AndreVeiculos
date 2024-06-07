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

        public int InsertTicket(Ticket ticket)
        {
            int result = 0;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    result = db.ExecuteScalar<int>(Ticket.INSERT, new
                    {
                        TNumber = ticket.Number,
                        ExpDate = ticket.ExpirationDate
                    });
                    db.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
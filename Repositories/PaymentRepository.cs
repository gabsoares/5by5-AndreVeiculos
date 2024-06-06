using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private string Conn;

        public PaymentRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertPayment(Payment payment)
        {
            bool status = false;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(Payment.INSERT, new
                    {
                        CCId = payment.CreditCard?.Id,
                        PixId = payment.Pix?.Id,
                        TicketId = payment.Ticket?.Id,
                        PayDate = payment.PaymentDate
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
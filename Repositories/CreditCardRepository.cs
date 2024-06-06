using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;
using System.Xml.Linq;

namespace Repositories
{
    public class CreditCardRepository : ICreditCardRepository
    {
        private string Conn;

        public CreditCardRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertCreditCard(CreditCard creditCard)
        {
            bool status = false;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(CreditCard.INSERT, new
                    {
                        CNumber = creditCard.CardNumber,
                        SecCode = creditCard.SecurityCode,
                        ExpDate = creditCard.ExpirationDate,
                        CHName = creditCard.CardHolderName
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

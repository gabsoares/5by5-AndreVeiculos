using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private string Conn;

        public PurchaseRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertPurchase(Purchase purchase)
        {
            bool status = false;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    //VALUES(@CarId, @PurcValue, @PurcDate)
                    db.Open();
                    db.Execute(Purchase.INSERT, new
                    {
                        CarId = purchase.Car?.CarPlate,
                        PurcValue = purchase.Price,
                        PurcDate = purchase.PurchaseDate,
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
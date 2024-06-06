using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private string Conn;

        public SaleRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertSale(Sale sale)
        {
            bool status = false;
            try
            {
                //VALUES(@CarId, @SaleDate, @SaleValue, @ClientId, @EmpId, @PayId)
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(Sale.INSERT, new
                    {
                        CarId = sale.Car?.CarPlate,
                        SaleDate = sale.SaleDate,
                        SaleValue = sale.SaleValue,
                        ClientId = sale.Client?.CPF,
                        EmpId = sale.Employee?.CPF,
                        PayId = sale.Payment?.Id
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
using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;
using System.Reflection.Emit;

namespace Repositories
{
    public class AdressRepository : IAdressRepository
    {
        private string Conn;

        public AdressRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }
        public bool InsertAdress(Adress adress)
        {
            bool result = false;

            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(Adress.INSERT, new
                    {
                        PublicPlace = adress.PublicPlace,
                        ZipCode = adress.ZipCode,
                        District = adress.District,
                        PPType = adress.PublicPlateType,
                        Complement = adress.Complement,
                        Number = adress.Number,
                        UF = adress.UF,
                        City = adress.City
                    });
                    db.Close();
                }
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}

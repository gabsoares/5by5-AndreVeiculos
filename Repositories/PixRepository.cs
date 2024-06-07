using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class PixRepository : IPixRepository
    {
        private string Conn;

        public PixRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public int InsertPix(Pix pix)
        {
            int result = 0;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    result = db.ExecuteScalar<int>(Pix.INSERT, new
                    {
                        TpPixId = pix.PixType?.Id,
                        PixKey = pix.PixKey
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
using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class PixTypeRepository : IPixTypeRepository
    {
        private string Conn;

        public PixTypeRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public int InsertPixType(PixType pixType)
        {
            int result = 0;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    result = db.ExecuteScalar<int>(PixType.INSERT, new
                    {
                        Desc = pixType.Description,
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
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

        public bool InsertPixType(PixType pixType)
        {
            bool status = false;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(PixType.INSERT, new
                    {
                        Desc = pixType.Description,
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
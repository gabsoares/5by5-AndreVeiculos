using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private string Conn;

        public RoleRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertRole(Role role)
        {
            bool status = false;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(Role.INSERT, new
                    {
                        Desc = role.Description,
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

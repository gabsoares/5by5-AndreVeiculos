using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class ClientRepository : IClientRepository
    {
        private string Conn;

        public ClientRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }
        public bool InsertClient(Client client)
        {
            bool result = false;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(Client.INSERT, new
                    {
                        CPF = client.CPF,
                        Name = client.Name,
                        DateBirth = client.DateOfBirth,
                        IdAdress = client.Adress?.Id,
                        Phone = client.Phone,
                        Email = client.Email,
                        Income = client.Income,
                        PdfDoc = client.PDFDocument
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

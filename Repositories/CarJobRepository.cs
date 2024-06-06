using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class CarJobRepository : ICarJobRepository
    {
        private string Conn;

        public CarJobRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertCarJob(CarJob carJob)
        {
                bool result = false;

                try
                {
                    using (var db = new SqlConnection(Conn))
                    {
                        db.Open();
                        db.Execute(CarJob.INSERT, new
                        {
                            CarId = carJob.Car.CarPlate,
                            ServiceId = carJob.Job.Id,
                            StatusService = carJob.Status
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

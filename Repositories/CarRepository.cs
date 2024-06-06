using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class CarRepository : ICarRepository
    {
        private string Conn;

        public CarRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }
        public bool InsertCar(Car car)
        {
            bool status = false;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(Car.INSERT, new
                    {
                        Plate = car.CarPlate,
                        Name = car.CarName,
                        Color = car.CarColor,
                        ModelYear = car.ModelYear,
                        FabricationYear = car.FabricationYear,
                        IsSold = car.IsSold
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

        public List<String> GetAllCarPlate()
        {
            List<String> temp = new();
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                var carPlates = db.Query("SELECT CAR_PLATE FROM TB_CAR");
                foreach (var item in carPlates)
                {
                    temp.Add(item.CAR_PLATE);
                }
                db.Close();
                return (List<string>)carPlates;
            }
        }
    }
}
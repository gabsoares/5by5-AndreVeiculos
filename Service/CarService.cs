using Models;
using Repositories;
using Repositories.Interface;

namespace Service
{
    public class CarService
    {
        private ICarRepository _carRepository;

        public CarService()
        {
            _carRepository = new CarRepository();
        }

        public bool InsertCar(Car car)
        {
            return _carRepository.InsertCar(car);
        }

        public string GenerateCarPlate()
        {
            Random random = new();
            string plateLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


            string carPlateLetters = "";
            for (int y = 0; y < 3; y++)
            {
                carPlateLetters += plateLetters[random.Next(0, plateLetters.Length)];
            }

            string carPlateNumbers = "";
            for (int j = 0; j < 4; j++)
            {
                carPlateNumbers += random.Next(0, 9);
            }

            string carPlate = carPlateLetters + carPlateNumbers;

            return carPlate;
        }
    }
}

using Models;
using Service;

namespace Controllers
{
    public class CarController
    {
        private CarService _carService;

        public CarController()
        {
            _carService = new CarService();
        }

        public bool InsertCar(Car car)
        {
            return _carService.InsertCar(car);
        }
    }
}

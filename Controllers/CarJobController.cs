using Models;
using Services;

namespace Controllers
{
    public class CarJobController
    {
        private CarJobService _carJobService;

        public CarJobController()
        {
            _carJobService = new CarJobService();
        }

        public bool InsertCarJob(CarJob carJob)
        {
            return _carJobService.InsertCarJob(carJob);
        }
    }
}
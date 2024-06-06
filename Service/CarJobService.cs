using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class CarJobService
    {
        private ICarJobRepository _carJobRepository;

        public CarJobService()
        {
            _carJobRepository = new CarJobRepository();
        }
        
        public bool InsertCarJob(CarJob carJob)
        {
            return _carJobRepository.InsertCarJob(carJob);
        }
    }
}
using Models;

namespace Repositories.Interface
{
    public interface ICarJobRepository
    {
        bool InsertCarJob(CarJob carJob);
    }
}
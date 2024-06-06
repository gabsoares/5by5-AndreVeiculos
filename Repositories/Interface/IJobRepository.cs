using Models;

namespace Repositories.Interface
{
    public interface IJobRepository
    {
        bool InsertJob(Job job);
    }
}

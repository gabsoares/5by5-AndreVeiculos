using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class JobService
    {
        private IJobRepository _jobRepository;

        public JobService()
        {
            _jobRepository = new JobRepository();
        }

        public bool InsertJob(Job job)
        {
            return _jobRepository.InsertJob(job);
        }
    }
}

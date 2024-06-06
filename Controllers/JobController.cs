using Models;
using Services;

namespace Controllers
{
    public class JobController
    {
        private JobService _jobService;

        public JobController()
        {
            _jobService = new JobService();
        }

        public bool InsertJob(Job job)
        {
            return _jobService.InsertJob(job);
        }
    }
}
using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class JobRepository : IJobRepository
    {
        private string Conn;

        public JobRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertJob(Job job)
        {
            bool status = false;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(Job.INSERT, new
                    {
                        Desc = job.Description
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

        public List<String> GetAllJobIdName()
        {
            List<String> temp = new();
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                var jobList = db.Query("SELECT ID, DESCRIPTION_JOB FROM TB_JOB");
                foreach (var item in jobList)
                {
                    string jobIdName = $"Id: {item.ID} - Descricao: {item.DESCRIPTION_JOB}";
                    temp.Add(jobIdName);
                }
                db.Close();
                return (List<String>)jobList;
            }
        }
    }
}

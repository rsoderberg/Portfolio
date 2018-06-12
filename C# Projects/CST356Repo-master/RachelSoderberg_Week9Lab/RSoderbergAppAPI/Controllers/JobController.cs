using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RachelSoderberg_Lab2.Data.Entities;

namespace RSoderbergAppAPI.Controllers
{
    public class JobController : ApiController
    {
        Job[] jobs = new Job[]
        {
            new Job { Id = 1, JobName = "Banker", CompanyName = "Chase", Years = 10, Salary = 80000, UserId = 10001 },
            new Job { Id = 2, JobName = "Sales Associate", CompanyName = "Safeway", Years = 2, Salary = 24000, UserId = 10002 }
        };

        public IEnumerable<Job> GetAllJobs()
        {
            return jobs;
        }

        public IHttpActionResult GetJob(int id)
        {
            var job = jobs.FirstOrDefault((j) => j.Id == id);

            if (job == null)
            {
                return NotFound();
            }
            return Ok(job);
        }
    }
}

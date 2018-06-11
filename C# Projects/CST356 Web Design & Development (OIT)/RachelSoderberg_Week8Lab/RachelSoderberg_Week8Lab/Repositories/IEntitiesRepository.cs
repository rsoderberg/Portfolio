using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RachelSoderberg_Lab2.Data.Entities;

namespace RachelSoderberg_Lab2.Repositories
{
    public interface IEntitiesRepository
    {
        Job GetJob(int id);

        IEnumerable<Job> GetJobsForUser(string userId);

        void SaveJob(Job job);
        void UpdateJob(Job user);
        void DeleteJob(int id);
    }
}

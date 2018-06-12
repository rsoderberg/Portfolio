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
        User GetUser(int id);
        Job GetJob(int id);

        IEnumerable<User> GetAllUsers();
        IEnumerable<Job> GetJobsForUser(int userId);

        void SaveUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);

        void SaveJob(Job job);
        void UpdateJob(Job user);
        void DeleteJob(int id);
    }
}

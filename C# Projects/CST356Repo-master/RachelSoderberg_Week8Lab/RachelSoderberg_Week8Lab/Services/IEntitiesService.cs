using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RachelSoderberg_Lab2.Models.View;

namespace RachelSoderberg_Lab2.Services
{
    public interface IEntitiesService
    {
        //UserViewModel GetUser(int id);
        JobViewModel GetJob(int id);

        //IEnumerable<UserViewModel> GetAllUsers();
        IEnumerable<JobViewModel> GetJobsForUser(string userId);

        //void SaveUser(UserViewModel user);
        //void UpdateUser(UserViewModel user);
        //void DeleteUser(int id);
        void SaveJob(string userId, JobViewModel job);
        void UpdateJob(JobViewModel user);
        void DeleteJob(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RachelSoderberg_Lab2.Data;
using RachelSoderberg_Lab2.Data.Entities;

namespace RachelSoderberg_Lab2.Repositories
{
    public class EntitiesRepository : IEntitiesRepository
    {
        private readonly AppDbContext _dbContext;

        public EntitiesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // User Entity
        public User GetUser(int id)
        {
            return _dbContext.Users.Find(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _dbContext.Users;
        }

        public void SaveUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _dbContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _dbContext.Users.Find(id);

            if (user == null) return;

            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        // Job Entity
        public Job GetJob(int id)
        {
            return _dbContext.Jobs.Find(id);
        }

        public IEnumerable<Job> GetJobsForUser(int userId)
        {
            return _dbContext.Jobs.Where(job => job.UserId == userId).ToList();
        }

        public void SaveJob(Job job)
        {
            _dbContext.Jobs.Add(job);
            _dbContext.SaveChanges();
        }

        public void UpdateJob(Job job)
        {
            _dbContext.SaveChanges();
        }

        public void DeleteJob(int id)
        {
            var job = _dbContext.Jobs.Find(id);

            if (job == null) return;

            _dbContext.Jobs.Remove(job);
            _dbContext.SaveChanges();
        }
    }
}
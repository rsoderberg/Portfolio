using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RachelSoderberg_Lab2.Data.Entities;
using RachelSoderberg_Week8Lab.Models;

namespace RachelSoderberg_Lab2.Repositories
{
    public class EntitiesRepository : IEntitiesRepository
    {
        private readonly AppDbContext _dbContext;

        public EntitiesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Job GetJob(int id)
        {
            return _dbContext.Jobs.Find(id);
        }

        public IEnumerable<Job> GetJobsForUser(string userId)
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
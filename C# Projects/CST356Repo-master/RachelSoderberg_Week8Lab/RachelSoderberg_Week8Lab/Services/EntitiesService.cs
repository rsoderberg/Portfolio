using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RachelSoderberg_Lab2.Data.Entities;
using RachelSoderberg_Lab2.Models.View;
using RachelSoderberg_Lab2.Repositories;

namespace RachelSoderberg_Lab2.Services
{
    public class EntitiesService : IEntitiesService
    {
        private readonly IEntitiesRepository _repository;

        public EntitiesService(IEntitiesRepository repository)
        {
            _repository = repository;
        }

        public JobViewModel GetJob(int id)
        {
            var job = _repository.GetJob(id);

            return MapToJobViewModel(job);
        }

        public IEnumerable<JobViewModel> GetJobsForUser(string userId)
        {
            var jobViewModels = new List<JobViewModel>();
            var jobs = _repository.GetJobsForUser(userId);

            foreach (var job in jobs)
            {
                jobViewModels.Add(MapToJobViewModel(job));
            }

            return jobViewModels;
        }

        public void SaveJob(string userId, JobViewModel jobViewModel)
        {
            var job = MapToJob(userId, jobViewModel);

            _repository.SaveJob(job);
        }

        public void UpdateJob(JobViewModel jobViewModel)
        {
            var job = _repository.GetJob(jobViewModel.Id);

            CopyToJob(jobViewModel, job);

            _repository.UpdateJob(job);
        }

        public void DeleteJob(int id)
        {
            _repository.DeleteJob(id);
        }

        private Job MapToJob(string userId, JobViewModel jobViewModel)
        {
            return new Job
            {
                Id = jobViewModel.Id,
                JobName = jobViewModel.JobName,
                CompanyName = jobViewModel.CompanyName,
                Years = jobViewModel.Years,
                Salary = jobViewModel.Salary,
                UserId = jobViewModel.UserId
            };
        }

        private JobViewModel MapToJobViewModel(Job job)
        {
            var jobViewModel = new JobViewModel
            {
                Id = job.Id,
                JobName = job.JobName,
                CompanyName = job.CompanyName,
                Years = job.Years,
                Salary = job.Salary,
                UserId = job.UserId
            };

            jobViewModel.TotalIncome = (jobViewModel.Years * jobViewModel.Salary);

            return jobViewModel;
        }

        private void CopyToJob(JobViewModel jobViewModel, Job job)
        {
            job.Id = jobViewModel.Id;
            job.JobName = jobViewModel.JobName;
            job.CompanyName = jobViewModel.CompanyName;
            job.Years = jobViewModel.Years;
            job.Salary = jobViewModel.Salary;
            job.UserId = jobViewModel.UserId;
        }
    }
}
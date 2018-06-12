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

        public EntitiesService(IEntitiesRepository entitiesRepository)
        {
            _repository = entitiesRepository;
        }

        // User Entity
        public UserViewModel GetUser(int id)
        {
            var user = _repository.GetUser(id);

            return (MapToUserViewModel(user));
        }

        public IEnumerable<UserViewModel> GetAllUsers()
        {
            var userViewModels = new List<UserViewModel>();
            var users = _repository.GetAllUsers();

            foreach (var user in users)
            {
                userViewModels.Add(MapToUserViewModel(user));
            }

            return userViewModels;
        }

        public void SaveUser(UserViewModel userViewModel)
        {
            // throw new Exception("Test Exception");

            _repository.SaveUser(MapToUser(userViewModel));
        }

        public void UpdateUser(UserViewModel userViewModel)
        {
            var user = _repository.GetUser(userViewModel.Id);
            CopyToUser(userViewModel, user);

            _repository.UpdateUser(user);
        }

        public void DeleteUser(int id)
        {
            _repository.DeleteUser(id);
        }

        private void CopyToUser(UserViewModel userViewModel, User user)
        {
            user.FirstName = userViewModel.FirstName;
            user.MiddleName = userViewModel.MiddleName;
            user.LastName = userViewModel.LastName;
            user.EmailAddress = userViewModel.EmailAddress;
            user.UserName = userViewModel.UserName;
            user.YearsInSchool = userViewModel.YearsInSchool;
            user.FavoritePizzaTopping = userViewModel.FavoritePizzaTopping;
        }

        private User MapToUser(UserViewModel userViewModel)
        {
            return new User
            {
                Id = userViewModel.Id,
                FirstName = userViewModel.FirstName,
                MiddleName = userViewModel.MiddleName,
                LastName = userViewModel.LastName,
                EmailAddress = userViewModel.EmailAddress,
                UserName = userViewModel.UserName,
                YearsInSchool = userViewModel.YearsInSchool,
                FavoritePizzaTopping = userViewModel.FavoritePizzaTopping
            };
        }

        private UserViewModel MapToUserViewModel(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                EmailAddress = user.EmailAddress,
                UserName = user.UserName,
                YearsInSchool = user.YearsInSchool,
                FavoritePizzaTopping = user.FavoritePizzaTopping
            };
        }

        // Job Entity
        public JobViewModel GetJob(int id)
        {
            var job = _repository.GetJob(id);

            return MapToJobViewModel(job);
        }

        public IEnumerable<JobViewModel> GetJobsForUser(int userId)
        {
            var jobViewModels = new List<JobViewModel>();
            var jobs = _repository.GetJobsForUser(userId);

            foreach (var job in jobs)
            {
                jobViewModels.Add(MapToJobViewModel(job));
            }

            return jobViewModels;
        }

        public void SaveJob(JobViewModel jobViewModel)
        {
            var job = MapToJob(jobViewModel);

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

        private Job MapToJob(JobViewModel jobViewModel)
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
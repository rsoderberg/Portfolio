using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RachelSoderberg_Lab2.Data;
using RachelSoderberg_Lab2.Data.Entities;
using RachelSoderberg_Lab2.Models.View;

namespace RachelSoderberg_Lab2.Controllers
{
    public class JobController : Controller
    {
        public ActionResult List(int userId)
        {
            ViewBag.UserId = userId;

            var jobs = GetJobsForUser(userId);

            return View(jobs);
        }

        [HttpGet]
        public ActionResult Create(int userId)
        {
            ViewBag.UserId = userId;

            return View();
        }

        [HttpPost]
        public ActionResult Create(JobViewModel jobViewModel)
        {
            if (ModelState.IsValid)
            {
                Save(jobViewModel);

                return RedirectToAction("List", new { UserId = jobViewModel.UserId });
            }

            return View();
        }

        /*
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var job = GetJob(id);

            return View(job);
        }

        [HttpPost]
        public ActionResult Edit(JobViewModel jobViewModel)
        {
            if (ModelState.IsValid)
            {
                UpdateJob(jobViewModel);

                return RedirectToAction("List");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var job = GetJob(id);

            return View();
        }
        */

        public ActionResult Delete(int id)
        {
            var job = GetJob(id);

            DeleteJob(id);

            return RedirectToAction("List", new { UserId = job.UserId });
        }

        private void DeleteJob(int id)
        {
            var dbContext = new AppDbContext();
            var job = dbContext.Jobs.Find(id);

            if (job != null)
            {
                dbContext.Jobs.Remove(job);
                dbContext.SaveChanges();
            }
        }

        private void CopyToJob(JobViewModel jobViewModel, Job job)
        {
            job.JobName = jobViewModel.JobName;
            job.CompanyName = jobViewModel.CompanyName;
            job.Years = jobViewModel.Years;
            job.Salary = jobViewModel.Salary;
        }

        private void SaveJob(Job job)
        {
            var dbContext = new AppDbContext();

            dbContext.Jobs.Add(job);
            dbContext.SaveChanges();
        }

        private void UpdateJob(JobViewModel jobViewModel)
        {
            var dbContext = new AppDbContext();
            var job = dbContext.Jobs.Find(jobViewModel.Id);

            CopyToJob(jobViewModel, job);
            dbContext.SaveChanges();
        }

        private Job GetJob(int jobId)
        {
            var dbContext = new AppDbContext();

            return dbContext.Jobs.Find(jobId);
        }

        private ICollection<JobViewModel> GetJobsForUser(int userId)
        {
            var jobViewModels = new List<JobViewModel>();
            var dbContext = new AppDbContext();
            var jobs = dbContext.Jobs.Where(job => job.UserId == userId).ToList();

            foreach (var job in jobs)
            {
                var jobViewModel = MapToJobViewModel(job);
                jobViewModels.Add(jobViewModel);
            }

            return jobViewModels;
        }

        private void Save(JobViewModel jobViewModel)
        {
            var dbContext = new AppDbContext();
            var job = MapToJob(jobViewModel);

            dbContext.Jobs.Add(job);
            dbContext.SaveChanges();
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
            return new JobViewModel
            {
                Id = job.Id,
                JobName = job.JobName,
                CompanyName = job.CompanyName,
                Years = job.Years,
                Salary = job.Salary,
                UserId = job.UserId
            };
        }
    }
}
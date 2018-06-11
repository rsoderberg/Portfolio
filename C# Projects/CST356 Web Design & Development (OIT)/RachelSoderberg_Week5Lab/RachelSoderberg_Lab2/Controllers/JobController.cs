using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RachelSoderberg_Lab2.Data;
using RachelSoderberg_Lab2.Data.Entities;
using RachelSoderberg_Lab2.Models.View;
using RachelSoderberg_Lab2.Services;

namespace RachelSoderberg_Lab2.Controllers
{
    public class JobController : Controller
    {
        private readonly IEntitiesService _entitiesService;
        // private readonly ILog _log = log4net.LogManager.GetLogger(typeof(JobController));

        public JobController(IEntitiesService entitiesService)
        {
            _entitiesService = entitiesService;
        }
        
        public ActionResult List(int userId)
        {
            // _log.Debug("Getting list of jobs for user: " + userId);

            ViewBag.UserId = userId;

            var jobViewModels = _entitiesService.GetJobsForUser(userId);

            return View(jobViewModels);
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
                _entitiesService.SaveJob(jobViewModel);

                return RedirectToAction("List", new { UserId = jobViewModel.UserId });
            }

            return View();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var job = _entitiesService.GetJob(id);

            return View(job);
        }

        [HttpPost]
        public ActionResult Edit(JobViewModel jobViewModel)
        {
            if (ModelState.IsValid)
            {
                _entitiesService.UpdateJob(jobViewModel);

                return RedirectToAction("List");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            var job = _entitiesService.GetJob(id);

            _entitiesService.DeleteJob(id);

            return RedirectToAction("List", new { UserId = job.UserId });
        }
    }
}
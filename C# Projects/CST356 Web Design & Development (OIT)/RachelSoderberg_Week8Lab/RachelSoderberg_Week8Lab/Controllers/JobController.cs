using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
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
        
        [Authorize]
        public ActionResult List()
        {
            // _log.Debug("Getting list of jobs for user: " + userId);

            var userId = User.Identity.GetUserId();

            ViewBag.UserId = userId;

            var jobViewModels = _entitiesService.GetJobsForUser(userId);

            return View(jobViewModels);
        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        //public ActionResult Create(int userId)
        {
            var userId = User.Identity.GetUserId();

            ViewBag.UserId = userId;

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(JobViewModel jobViewModel)
        {
            if (!ModelState.IsValid) return View();

            try
            {
                var userId = User.Identity.GetUserId();
                _entitiesService.SaveJob(userId, jobViewModel);
            }
            catch (Exception ex)
            {
                //_log.Error("Failed to save job", ex);
                throw;
            }

            return RedirectToAction("List");
        }


        [HttpGet]
        [Authorize]
        public ActionResult Edit(int id)
        {
            var job = _entitiesService.GetJob(id);

            return View(job);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Edit(JobViewModel jobViewModel)
        {
            if (ModelState.IsValid)
            {
                _entitiesService.UpdateJob(jobViewModel);

                return RedirectToAction("List");
            }

            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult Details(int id)
        {
            var job = _entitiesService.GetJob(id);

            return View(job);
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            ///var job = _entitiesService.GetJob(id);

            _entitiesService.DeleteJob(id);

            return RedirectToAction("List");
        }
    }
}
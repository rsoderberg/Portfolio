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
    public class UserController : Controller
    {
        private readonly IEntitiesService _entitiesService;

        public UserController(IEntitiesService entitiesService)
        {
            _entitiesService = entitiesService;
        }

        public ActionResult List()
        {
            var userViewModels = _entitiesService.GetAllUsers();

            return View(userViewModels);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                _entitiesService.SaveUser(userViewModel);

                return RedirectToAction("List");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var userViewModel = _entitiesService.GetUser(id);

            return View(userViewModel);
        }

        [HttpPost]
        public ActionResult Edit(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                _entitiesService.UpdateUser(userViewModel);

                return RedirectToAction("List");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var userViewModel = _entitiesService.GetUser(id);

            return View(userViewModel);
        }

        public ActionResult Delete(int id)
        {
            _entitiesService.DeleteUser(id);

            return RedirectToAction("List");
        }
    }
}
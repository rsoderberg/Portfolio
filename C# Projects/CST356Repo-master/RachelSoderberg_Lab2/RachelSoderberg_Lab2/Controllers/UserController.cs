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
    public class UserController : Controller
    {
        public ActionResult List()
        {
            var users = GetAllUsers();

            return View(users);
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
                var user = MapToUser(userViewModel);
                SaveUser(user);

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
            var user = GetUser(id);

            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                UpdateUser(userViewModel);

                return RedirectToAction("List");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var user = GetUser(id);

            return View(user);
        }

        public ActionResult Delete(int id)
        {
            DeleteUser(id);

            return RedirectToAction("List");
        }

        private void DeleteUser(int id)
        {
            var dbContext = new AppDbContext();
            var user = dbContext.Users.Find(id);

            if (user != null)
            {
                dbContext.Users.Remove(user);
                dbContext.SaveChanges();
            }
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

        private void SaveUser(User user)
        {
            var dbContext = new AppDbContext();

            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        private void UpdateUser(UserViewModel userViewModel)
        {
            var dbContext = new AppDbContext();
            var user = dbContext.Users.Find(userViewModel.Id);

            CopyToUser(userViewModel, user);
            dbContext.SaveChanges();
        }

        private UserViewModel GetUser(int id)
        {
            var dbContext = new AppDbContext();
            var user = dbContext.Users.Find(id);

            return MapToUserViewModel(user);
        }

        private IEnumerable<UserViewModel> GetAllUsers()
        {
            var userViewModels = new List<UserViewModel>();
            var dbContext = new AppDbContext();

            foreach (var user in dbContext.Users)
            {
                var userViewModel = MapToUserViewModel(user);
                userViewModels.Add(userViewModel);
            }
            return userViewModels;
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
    }
}
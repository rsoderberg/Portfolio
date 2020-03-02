using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OITJP2016.Models;

namespace OITJP2016.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        //public ActionResult Index()
        //{
        //    WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();
        //    //dc.usp_AddNewUser("Bob Barker", "PriceIsWrong", "Bobby");
        //    User u = new Models.User();
        //    List<User> lus = u.GetUsers();
        //    return View(lus);
        //}

        //public ActionResult Create()
        //{

        //    return View();
        //}


        //[HttpPost]
        
        //public ActionResult Create([Bind(Include = "UserName, Password, FriendlyName")] User userInfo)
        //{
        //    WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();

        //    dc.usp_AddNewUser(userInfo.UserName, userInfo.Password, userInfo.FriendlyName);
        //    return RedirectToAction("Index");
        //}

        //public ActionResult Delete(int? id)
        //{

        //    User userDelete = new Models.User();

        //    //todo: need find by id function in model.
        //    foreach(User users in userDelete.GetUsers())
        //    {
        //        if(users.UserID == id)
        //        {
        //            userDelete = users;
        //            break;
        //        }
        //    }
        //    return View(userDelete);
        //}

        //[HttpPost, ActionName("Delete")]
        //public ActionResult Delete(int id)
        //{
        //    WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();

        //    User userDelete = new Models.User();

        //    //todo: need find by id function in model.
        //    foreach (User users in userDelete.GetUsers())
        //    {
        //        if (users.UserID == id)
        //        {
        //            userDelete = users;
        //            break;
        //        }
        //    }

        //    dc.usp_DeleteUser(userDelete.UserName);            

        //    return RedirectToAction("Index") ;
        //}

        //public ActionResult Edit(int? id)
        //{
        //    User editUser = new Models.User();
        //    editUser = editUser.GetUsers().Where(x => x.UserID == id).FirstOrDefault();

        //    return View(editUser);
        //}

        //[HttpPost]
        //public ActionResult Edit([Bind(Include = "UserName, Password, FriendlyName")] User editUser )
        //{
        //    WhiteElephantDBDataContext dc = new WhiteElephantDBDataContext();

        //    dc.usp_UpdateUser(editUser.UserName, editUser.FriendlyName, editUser.Password);

        //    return RedirectToAction("index");
        //}
    }
}
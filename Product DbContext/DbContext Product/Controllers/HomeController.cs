using DbContext_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbContext_Product.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "DbContext Product application home page.";
            return View();
        }

        IList<User> userList = new List<User>()
        {
            new User(){UserId = 1, UserName = "user1", UserPassword = "user1"},
            new User(){UserId = 2, UserName = "user2", UserPassword = "user2"}
        };

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User tempUser)
        {
            var user = userList.Where(s => s.UserName.Equals(tempUser.UserName) && s.UserPassword.Equals(tempUser.UserPassword)).FirstOrDefault();

            if (user != null)
            {
                Session["UserName"] = user.UserName.ToString();
                return RedirectToAction("Index", "Products", new { username = user.UserName });
            }
            else
            {
                return Content("Login failed");
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Home");
        }

        public ActionResult About()
        {
            ViewBag.Message = "DbContext Product application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "DbContext Product contact page.";

            return View();
        }
    }
}
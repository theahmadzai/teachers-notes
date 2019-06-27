using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Models;

namespace App.Controllers
{
    public class AccountController : Controller
    {
        private DbContext db = new DbContext();

        // GET: Account
        [HttpGet]
        public ActionResult Index()
        {           
            return View();
        }

        // GET: Account/Login
        [HttpGet]
        public ActionResult Login()
        {            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            var usr = db.Users.Single(u => u.Email == user.Email && u.Password == user.Password);

            if(usr != null) 
            {
                Session.Add("user", usr);
                return RedirectToAction("Index");

            }

            return View();
        }
    }
}
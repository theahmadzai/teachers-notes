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
        private Database db = new Database();

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
        public ActionResult Login(Teacher teacher)
        {
            var user = db.Teachers.Single(t => t.Email == teacher.Email && t.Password == teacher.Password);

            if(user != null) 
            {
                Session.Add("user", user);
                return RedirectToAction("Index");

            }

            return View();
        }
    }
}
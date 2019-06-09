using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        Database db = new Database();

        // GET: Home
        public ActionResult Index()
        {
            var teachers = db.Teachers.ToList();

            return View(teachers);
        }
    }
}
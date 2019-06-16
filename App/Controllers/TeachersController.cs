using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class TeachersController : Controller
    {
        private Database database = new Database();

        //[ChildActionOnly]//
        // GET: Teacher
        [HttpGet]
        public ActionResult Index(String name)
        {            
            return View(database.Teachers.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {           
            if (ModelState.IsValid)
            {
                database.Teachers.Add(teacher);
                database.SaveChanges();
            }            
            
            return View();
        }
    }
}
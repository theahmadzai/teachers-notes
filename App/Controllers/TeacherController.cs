using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class TeacherController : Controller
    {
        //[ChildActionOnly]//
        // GET: Teacher
        public ActionResult Index(String name)
        {
            var teachers = new List<Teacher> {
                new Teacher {
                    Id = 1,
                    Name = "Some Name",
                    Email = "Some@name.com",
                    Password = "password",
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime()
                },
                new Teacher {
                    Id = 2,
                    Name = "Ali",
                    Email = "Some@name.com",
                    Password = "password",
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime()
                },
                new Teacher {
                    Id = 3,
                    Name = "Ahmed",
                    Email = "Some@name.com",
                    Password = "password",
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime()
                }
            };

            return View(teachers);
        }
    }
}
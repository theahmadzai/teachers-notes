using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Models;

namespace App.Controllers
{
    public class ResourcesController : Controller
    {
        // GET: Resources
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Subject,Title")] Resource resource, HttpPostedFileBase upload)
        {
            //String img64 = Convert.ToBase64String(Model.Content);
            //String img64Url = string.Format("data:image/" + Model.ContentType + ";base64,{0}", img64);
            //< img src = "@img64Url" height = "200" width = "300" />
            if (ModelState.IsValid)
            {
                if (upload != null && upload.ContentLength > 0)
                {
                    var file = new File
                    {
                        FileName = System.IO.Path.GetFileName(upload.FileName),
                        ContentType = upload.ContentType
                    };
                    using (var reader = new System.IO.BinaryReader(upload.InputStream))
                    {
                        file.Content = reader.ReadBytes(upload.ContentLength);
                    }
                    resource.Files = new List<File> { file };
                }

                //resource.ApplicationUserId = User.Identity.GetUserId();

                //db.Resources.Add(resource);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(resource);
        }
    }
}
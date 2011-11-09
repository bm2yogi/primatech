using System;
using System.Web.Mvc;
using PrimatechMVC.Models;

namespace PrimatechMVC.Controllers
{
    public class EmployeesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public ActionResult Add(EmployeeProfile profile)
        {
            var viewName = "";
            if (ModelState.IsValid)
            {
                viewName = "Index";
                //process profile
            }

            return View(viewName);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(EmployeeProfile profile)
        {
            return View();
        }

        public ActionResult Detail()
        {
            var model = new EmployeeProfile
                            {
                                EmployeeId = 1337,
                                FirstName = "Mike",
                                LastName = "Ibarra",
                                Department = "IT",
                                Position = "Cog",
                                Email = "bm2yogi@gmail.com",
                                HireDate = new DateTime(2010, 10, 24)
                            };
            return View(model);
        }

        public JsonResult IsExistingEmail(string email)
        {
            var result = !email.ToLowerInvariant().Equals("bm2yogi@gmail.com");
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
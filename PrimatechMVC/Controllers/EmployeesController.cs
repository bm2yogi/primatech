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

        public JsonResult IsExistingEmail(string email)
        {
            var result = !email.ToLowerInvariant().Equals("bm2yogi@gmail.com");
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
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
            return View();
        }

        [HttpPost]
        public ActionResult Add(EmployeeProfile profile)
        {
            return View();
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
    }
}
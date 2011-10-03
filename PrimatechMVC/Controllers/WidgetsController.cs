using System.Web.Mvc;
using PrimatechMVC.Models;

namespace PrimatechMVC.Controllers
{
    public class WidgetsController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Widget widget)
        {
            return Json(widget);
        }

    }
}

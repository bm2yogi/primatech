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

        public ActionResult Add()
        {
            return View("Add");
        }

        public ActionResult Add(Widget widget)
        {
            if (!ModelState.IsValid)
                return View();

            return RedirectToAction("Add");
        }

        [HttpPost]
        public ActionResult Create(Widget widget)
        {
            if (!ModelState.IsValid)
                return View();

            return RedirectToAction("Create");
        }

        public JsonResult SkuExists(string sku)
        {
            return Json(!sku.ToLower().Contains("foo"), JsonRequestBehavior.AllowGet);
        }

    }
}

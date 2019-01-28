using MVCRockers.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockers.Controllers
{
    //[Authorize(Roles ="Admin",Users ="ruchita")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       
        [MyloggingFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "What do you think?.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string message)
        {
            //save this and act
            ViewBag.message = "Thanks for your feedback!";
            return PartialView("_ThanksForFeedBack");
        }

        public ActionResult Backstage(string secret, string format)
        {
            if (secret != "special")
                return new HttpStatusCodeResult(403);
            if (format == "text")
                return Content("you rock");
            else if (format == "json")
                return Json(new { password = "you rock", expires = DateTime.UtcNow.ToShortDateString() }, JsonRequestBehavior.AllowGet);
            else if (format == "clean")
                return PartialView();
            return View();
        }
    }
}
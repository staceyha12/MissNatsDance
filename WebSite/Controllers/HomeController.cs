using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Newsletters()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Teachers()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Timetable()
        {
            ViewBag.Message = "Your timetable page.";

            return View();
        }
        public ActionResult Classes()
        {
            ViewBag.Message = "Your timetable page.";

            return View();
        }
        public ActionResult Performances()
        {
            ViewBag.Message = "Your timetable page.";

            return View();
        }
        public ActionResult Choreo()
        {
            ViewBag.Message = "Your timetable page.";

            return View();
        }
        public ActionResult Concert()
        {
            ViewBag.Message = "Your timetable page.";

            return View();
        }

        public ActionResult Workshops()
        {
            ViewBag.Message = "Your timetable page.";

            return View();
        }
        public ActionResult Parties()
        {
            ViewBag.Message = "Your timetable page.";

            return View();
        }
        public ActionResult Policies()
        {
            ViewBag.Message = "Your timetable page.";

            return View();
        }
        public ActionResult Pricing()
        {
            ViewBag.Message = "Your timetable page.";

            return View();
        }
        public ActionResult Philosophy()
        {
            ViewBag.Message = "";
            return View();
        }
       
     
    }
}
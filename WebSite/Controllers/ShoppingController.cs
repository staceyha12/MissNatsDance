using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShoppingCart
        public ActionResult ShoppingCart()
        {
            return View();
        }

        // GET: Browse
        public ActionResult Browse()
        {
            return View();
        }
    }
}
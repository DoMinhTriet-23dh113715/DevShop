using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevShop1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Trangchu()
        {
            return View();
        }

        //public ActionResult Login()
        //{
        //    return View();
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
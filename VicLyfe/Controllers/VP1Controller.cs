using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VicLyfe.Controllers
{
    public class VP1Controller : Controller
    {

        public ActionResult ViewPage1()
        {
            ViewBag.Message = "View comparison of Metropolitan and Regional Areas";

            return View();
        }

        public ActionResult HospitalVP1()
        {
            return View();
        }

        public ActionResult ParkVP1()
        {
            return View();
        }

        public ActionResult RTOVP1()
        {
            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VicLyfe.Controllers
{
    public class VP2Controller : Controller
    {

        public ActionResult ViewPage2()
        {
            ViewBag.Message = "Comparison of different Regional Areas in Victoria in terms of Crime, Jobs and Rent";

            return View();
        }

        public ActionResult HospitalVP2()
        {
            return View();
        }

        public ActionResult ParkVP2()
        {
            return View();
        }

        public ActionResult RTOVP2()
        {
            return View();
        }

    }
}
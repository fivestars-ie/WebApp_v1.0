using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VicLyfe.Controllers
{
    public class VP3Controller : Controller
    {

        public ActionResult ViewPage3()
        {
            ViewBag.Message = "Select and view data about your City!";

            return View();
        }
    }
}
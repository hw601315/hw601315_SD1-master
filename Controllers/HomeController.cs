using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hw601315_SD1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Me";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hannah Wilson";

            return View();
        }
    }
}
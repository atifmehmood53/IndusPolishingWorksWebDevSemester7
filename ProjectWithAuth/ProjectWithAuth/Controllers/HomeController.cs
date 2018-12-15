using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectWithAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our service company was born with a motto: 'Strength is your Shine', back in 1990.";
            ViewBag.Message = "Since then, we are working hard to estalish as the leading metal polishing company of Pakistan.";
            ViewBag.Message = "We provide various polishing services:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
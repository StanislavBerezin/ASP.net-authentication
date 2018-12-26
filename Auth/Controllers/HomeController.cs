using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auth.Controllers
{
    //[Authorize]
    //will cause everything to be authorised
    //[AllowAnonymus] to allow something
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // authorize hides the page from unathorized users
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
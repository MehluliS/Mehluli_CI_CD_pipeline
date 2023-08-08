using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLDFA2Mehluli.Controllers
{
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

        public ActionResult locations()
        {
            ViewBag.Message = "Your locations page.";

            return View();
        }
        public ActionResult favorites()
        {
            ViewBag.Message = "Your favorites.";

            return View();
        }
        public ActionResult latestNews()
        {
            

            return Redirect("https://www.marvel.com/comics/calendar?&offset=0&totalcount=20");
        }
    }
}
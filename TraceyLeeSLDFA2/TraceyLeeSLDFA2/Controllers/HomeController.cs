using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TraceyLeeSLDFA2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LatestNews()
        {
            ViewBag.Message = "Your Latest News page.";

            return Redirect("https://screenrant.com/comics/");
        }

        public ActionResult Location()
        {
          

            return View();
        }

        public ActionResult Favourites()
        {
            ViewBag.Message = "YourFavourites page.";

            return View();
        }
    }
}
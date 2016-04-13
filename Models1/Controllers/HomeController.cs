using Models1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models1.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext db = new MovieContext();



        public ActionResult Index()
        {
            var viewModel = ViewBag.Movies = db.Movies
                .OrderByDescending(m => m.ReleaseDate)
                .Take(3)
                .ToList();

            return View(viewModel);
        }

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
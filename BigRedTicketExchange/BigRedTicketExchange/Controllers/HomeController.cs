using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BigRedTicketExchange.Models;

namespace BigRedTicketExchange.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeIndexViewModel HIModel = new HomeIndexViewModel();
            using(var db = new BrteDBContext())
            {
                HIModel.Sports.Add(db.Sports.Where(x => x.Name == "Football").Single());
                //HIModel.Sports.Add(db.Sports.Where(x => x.Name == "Volleyball").Single());
                //HIModel.Sports.Add(db.Sports.Where(x => x.Name == "Men's Basketball").Single());

                foreach (var sport in HIModel.Sports)
                {
                    foreach (var game in sport.Games)
                    {

                    }
                }

            }

            return View(HIModel);
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
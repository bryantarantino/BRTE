using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BigRedTicketExchange.Models;
using Microsoft.AspNet.Identity;

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
                HIModel.Sports.Add(db.Sports.Where(x => x.Name == "Volleyball").Single());
                HIModel.Sports.Add(db.Sports.Where(x => x.Name == "Basketball").Single());
                TimeSpan limitTime = new TimeSpan(3, 0, 0);
                foreach (var sport in HIModel.Sports)
                {
                    foreach (var game in sport.Games)
                    {
                        TimeSpan diffTime = game.Date.Subtract(DateTime.Now);
                        if(TimeSpan.Compare(limitTime, diffTime) < 0)
                        {
                            game.IsActive = true;
                        }
                        else
                        {
                            game.IsActive = false;
                        }
                    }
                }

            }
            using (var db = new ApplicationDbContext())
            {
                HIModel.User = db.Users.Where(x => x.UserName == User.Identity.GetUserName()).Single();
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
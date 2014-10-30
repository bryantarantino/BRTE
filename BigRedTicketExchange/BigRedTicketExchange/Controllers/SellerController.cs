using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BigRedTicketExchange.Models;

namespace BigRedTicketExchange.Controllers
{
    public class SellerController : Controller
    {
        // GET: Seller
        public ActionResult Index(string userId, int gameId)
        {
            UserTicketViewModel UTicket = new UserTicketViewModel();
            using (var Udb = new ApplicationDbContext())
            {
                using (var Bdb = new BrteDBContext())
                {
                    var game = Bdb.Games.Where(x => x.GameID == gameId).Single();
                    var user = Udb.Users.Where(x => x.Id == userId).Single();
                    UTicket.Game = game;
                    UTicket.User = user;
                }
            }

            return View(UTicket);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult PostTicket(UserTicketViewModel model, string userId, int gameId)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            using (var Appdb = new ApplicationDbContext())
            {
                var user = Appdb.Users.Where(x => x.Id == userId);
                var dbUser = Appdb.Users.Where(x => x.Id == userId).Single();

                if (model.User.PhoneNumber != null)
                {
                    dbUser.PhoneNumber = model.User.PhoneNumber;
                }
                if (model.User.FullName != null)
                {
                    dbUser.FullName = model.User.FullName;
                }
                Appdb.SaveChanges();
                using (var BrteDb = new BrteDBContext())
                {
                    var game = BrteDb.Games.Where(x => x.GameID == gameId).Single();
                    foreach(var t in game.Tickets)
                    {
                        if (t.UserID == userId)
                        {
                            ViewBag.AlerMessage = "You have already Posted a ticket for this game";
                            return RedirectToAction("Index", "Home", null);
                        }
                    }
                    var ticket = new Ticket();


                    ticket.GameID = gameId;
                    ticket.UserID = userId;
                    ticket.IsAvailable = true;
                    BrteDb.Tickets.Add(ticket);

                    var dbGame = BrteDb.Games.Where(x => x.GameID == game.GameID).Single();
                    dbGame.Tickets.Add(ticket);

                    dbUser.Tickets.Add(ticket);
                    BrteDb.SaveChanges();
                }
            }
            return RedirectToAction("Index", "Home", null);

        }
        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

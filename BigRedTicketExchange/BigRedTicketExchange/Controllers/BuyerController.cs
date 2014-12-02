using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BigRedTicketExchange.Models;

namespace BigRedTicketExchange.Controllers
{
    public class BuyerController : Controller
    {
        // GET: Buyer
        public ActionResult Index(int gameId)
        {
            List<BuyerViewModel> BVList = new List<BuyerViewModel>();
            Game game = new Game();
            using (var db = new BrteDBContext())
            {
                game = db.Games.Where(x => x.GameID == gameId ).Single();
                foreach (var ticket in game.Tickets)
                {

                }

            }
            using(var db = new ApplicationDbContext()){
            foreach (var ticket in game.Tickets)
            {
                if (ticket.Visible == true)
                {
                    BuyerViewModel BV = new BuyerViewModel();
                    BV.Ticket = ticket;
                    BV.User = db.Users.Where(x => x.Id == ticket.UserID).Single();
                    BVList.Add(BV);
                }
            }
            }
            return View(BVList);
        }

        // GET: Buyer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Buyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buyer/Create
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

        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buyer/Edit/5
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

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
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

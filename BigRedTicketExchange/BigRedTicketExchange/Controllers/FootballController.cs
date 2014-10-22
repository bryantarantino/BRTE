using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigRedTicketExchange.Controllers
{
    public class FootballController : Controller
    {
        // GET: Football
        public ActionResult Index()
        {
            return View();
        }

        // GET: Football/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Football/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Football/Create
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

        // GET: Football/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Football/Edit/5
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

        // GET: Football/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Football/Delete/5
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

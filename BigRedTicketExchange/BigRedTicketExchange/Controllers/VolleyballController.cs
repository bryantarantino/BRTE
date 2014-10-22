using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigRedTicketExchange.Controllers
{
    public class VolleyballController : Controller
    {
        // GET: Volleyball
        public ActionResult Index()
        {
            return View();
        }

        // GET: Volleyball/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Volleyball/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Volleyball/Create
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

        // GET: Volleyball/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Volleyball/Edit/5
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

        // GET: Volleyball/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Volleyball/Delete/5
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

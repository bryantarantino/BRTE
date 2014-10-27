﻿using BigRedTicketExchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigRedTicketExchange.Controllers
{
    public class SportController : Controller
    {
        // GET: Sport
        public ActionResult FootballIndex()
        {
            Sport football = new Sport();
            using (var db = new BrteDBContext())
            {
                football = db.Sports.Where(x => x.Name == "Football").Single();
            }
            return View(football);
        }

        // GET: Sport/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sport/Create
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

        // GET: Sport/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sport/Edit/5
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

        // GET: Sport/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sport/Delete/5
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

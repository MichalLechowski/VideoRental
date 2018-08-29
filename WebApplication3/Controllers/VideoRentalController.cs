using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Context;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class VideoRentalController : Controller
    {
        VideoRentalContext db = new VideoRentalContext();

        // GET: VideoRental
        public ActionResult Index()
        {
            return View(db.Wypozyczenia.ToList());
        }

        // GET: VideoRental/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VideoRental/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoRental/Create
        [HttpPost]
        public ActionResult Create(Wypozyczenia wypozyczenia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Wypozyczenia.Add(wypozyczenia);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(wypozyczenia);
            }
            catch
            {
                return View();
            }
        }

        // GET: VideoRental/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VideoRental/Edit/5
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

        // GET: VideoRental/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VideoRental/Delete/5
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

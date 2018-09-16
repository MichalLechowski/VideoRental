using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppVideoRental.Context;
using WebAppVideoRental.Models;
using WebAppVideoRental.Models.DTO;
using WebAppVideoRental.Models.Repo;

namespace WebAppVideoRental.Controllers
{
    public class KlienciController : Controller
    {
        readonly VideoRentalContext db = new VideoRentalContext();

        // GET: VideoRental
        public ActionResult Index()
        {
            ICrudRepository<KlienciDto> repo = new KlientRepository();
            return View(repo.GetAll());
        }

        // GET: VideoRental/Details/5
        public ActionResult Details(int id)
        {
            //non-nullable int
            //if (id == null)
            //{
            //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            ICrudRepository<KlienciDto> repo = new KlientRepository();
            KlienciDto klient = repo.GetSingle(id);
            return View(klient);
        }

        // GET: VideoRental/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoRental/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KlienciDto klient)
        {
            if (ModelState.IsValid)
            {
                ICrudRepository<KlienciDto> repo = new KlientRepository();
                repo.Add(klient);
                return RedirectToAction("Index");
            }
            return View(klient);
        }

        // GET: VideoRental/Edit/5
        public ActionResult Edit(int id)
        {
            ICrudRepository<KlienciDto> repo = new KlientRepository();
            KlienciDto klienci = repo.GetSingle(id);

            if (klienci == null)
            {
                return HttpNotFound();
            }
            return View(klienci);
        }

        // POST: VideoRental/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(KlienciDto klient)
        {
            if (ModelState.IsValid)
            {
                ICrudRepository<KlienciDto> repo = new KlientRepository();
                if (repo.Update(klient))
                {
                    return RedirectToAction("Index");
                }
            }
            return View(klient);
        }

        // GET: VideoRental/Delete/5
        public ActionResult Delete(int id)
        {
            ICrudRepository<KlienciDto> repo = new KlientRepository();
            KlienciDto klienci = repo.GetSingle(id);
            if (klienci == null)
            {
                return HttpNotFound();
            }
            return View(klienci);
        }

        // POST: VideoRental/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                ICrudRepository<KlienciDto> repo = new KlientRepository();
                repo.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
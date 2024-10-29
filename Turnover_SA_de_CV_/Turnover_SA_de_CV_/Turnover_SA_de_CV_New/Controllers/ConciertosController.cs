using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Turnover_SA_de_CV_.Models;

namespace Turnover_SA_de_CV.Controllers
{
    public class ConciertosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Conciertos
        public ActionResult Index()
        {
            var conciertos = db.Conciertos.ToList();
            return View(conciertos);
        }

        // GET: Conciertos/Details/5
        public ActionResult Details(int id)
        {
            var concierto = db.Conciertos.Find(id);
            if (concierto == null)
            {
                return HttpNotFound();
            }
            return View(concierto);
        }

        // GET: Conciertos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conciertos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Concierto concierto)
        {
            if (ModelState.IsValid)
            {
                db.Conciertos.Add(concierto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(concierto);
        }

        // GET: Conciertos/Edit/5
        public ActionResult Edit(int id)
        {
            var concierto = db.Conciertos.Find(id);
            if (concierto == null)
            {
                return HttpNotFound();
            }
            return View(concierto);
        }

        // POST: Conciertos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Concierto concierto)
        {
            if (ModelState.IsValid)
            {
                var existingConcierto = db.Conciertos.Find(concierto.ConciertoID);
                if (existingConcierto == null)
                {
                    return HttpNotFound();
                }
                existingConcierto.Nombre = concierto.Nombre;
                existingConcierto.Fecha = concierto.Fecha;
                existingConcierto.Lugar = concierto.Lugar;
                db.Entry(existingConcierto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(concierto);
        }

        // GET: Conciertos/Delete/5
        public ActionResult Delete(int id)
        {
            var concierto = db.Conciertos.Find(id);
            if (concierto == null)
            {
                return HttpNotFound();
            }
            return View(concierto);
        }

        // POST: Conciertos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var concierto = db.Conciertos.Find(id);
            if (concierto == null)
            {
                return HttpNotFound();
            }

            db.Conciertos.Remove(concierto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Liberar los recursos del contexto de datos
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
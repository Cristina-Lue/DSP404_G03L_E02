using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Fluent.Infrastructure.FluentModel;
namespace Turnover_SA_de_CV_.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Dashboard()
        {
            if (Session["UsuarioID"] == null)
            {
                return RedirectToAction("Login", "Cuenta");
            }

            try
            {
                // Prueba explícita de conexión
                if (db.Database.Exists())
                {
                    var conciertos = db.Conciertos.ToList();
                    ViewBag.Message = "Conexión exitosa";
                    return View(conciertos);
                }
                else
                {
                    ViewBag.Error = "La base de datos no existe";
                    return View(new List<Concierto>());
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Error de conexión: {ex.Message}";
                return View(new List<Concierto>());
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && db != null)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
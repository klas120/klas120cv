using KennethCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KennethCV.Controllers
{
    public class HomeController : Controller
    {
        CVitaeDb _db = new CVitaeDb();

        public ActionResult Index()
        {
            //var model = _db.Users.ToList();

            ViewBag.users = _db.Users.ToList();
            ViewBag.educations = _db.Educations.ToList();
            ViewBag.experiences = _db.Experiences.ToList();
            ViewBag.refferences = _db.Refferences.ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página de descripción de la aplicación.";

            // Lazy Loading with Method Include
            var mispruebas = _db.Users.Include("Refferences").ToList();

            ViewBag.mispruebas = mispruebas;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contacto.";

            return View();
        }
    }
}

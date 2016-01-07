using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KennethCV.Models;

namespace KennethCV.Controllers
{
    [Authorize]
    public class ExperienceController : Controller
    {
        private CVitaeDb _db = new CVitaeDb();

        //
        // GET: /Experiences/

        public ViewResult Index()
        {
            return View(_db.Experiences.ToList());
        }

        //
        // GET: /Experiences/Details/5

        public ViewResult Details(int id)
        {
            Experience Experiences = _db.Experiences.Single(x => x.Id == id);
            return View(Experiences);
        }

        //
        // GET: /Experiences/Create

        public ActionResult Create()
        {
            ViewBag.PossibleUser = _db.Users;
            return View();
        } 

        //
        // POST: /Experiences/Create

        [HttpPost]
        public ActionResult Create(Experience Experiences)
        {
            if (ModelState.IsValid)
            {
                _db.Experiences.Add(Experiences);
                _db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleUser = _db.Users;
            return View(Experiences);
        }
        
        //
        // GET: /Experiences/Edit/5
 
        public ActionResult Edit(int id)
        {
            Experience Experiences = _db.Experiences.Single(x => x.Id == id);
            ViewBag.PossibleUser = _db.Users;
            return View(Experiences);
        }

        //
        // POST: /Experiences/Edit/5

        [HttpPost]
        public ActionResult Edit(Experience Experiences)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(Experiences).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleUser = _db.Users;
            return View(Experiences);
        }

        //
        // GET: /Experiences/Delete/5
 
        public ActionResult Delete(int id)
        {
            Experience Experiences = _db.Experiences.Single(x => x.Id == id);
            return View(Experiences);
        }

        //
        // POST: /Experiences/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Experience Experiences = _db.Experiences.Single(x => x.Id == id);
            _db.Experiences.Remove(Experiences);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
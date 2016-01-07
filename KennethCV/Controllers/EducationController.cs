using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KennethCV.Models;

namespace KennethCV.Controllers
{   [Authorize]
    public class EducationController : Controller
    {
        private CVitaeDb _db = new CVitaeDb();

        //
        // GET: /Education/

        public ViewResult Index()
        {
            return View(_db.Educations.ToList());
        }

        //
        // GET: /Educations/Details/5

        public ViewResult Details(int id)
        {
            Education Educations = _db.Educations.Single(x => x.Id == id);
            return View(Educations);
        }

        //
        // GET: /Education/Create

        public ActionResult Create()
        {
            ViewBag.PossibleUser = _db.Users;
            return View();
        } 

        //
        // POST: /Education/Create

        [HttpPost]
        public ActionResult Create(Education education)
        {
            if (ModelState.IsValid)
            {
                _db.Educations.Add(education);
                _db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleUser = _db.Users;
            return View(education);
        }
        
        //
        // GET: /Education/Edit/5
 
        public ActionResult Edit(int id)
        {
            Education education = _db.Educations.Single(x => x.Id == id);
            ViewBag.PossibleUser = _db.Users;
            return View(education);
        }

        //
        // POST: /Education/Edit/5

        [HttpPost]
        public ActionResult Edit(Education education)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(education).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleUser = _db.Users;
            return View(education);
        }

        //
        // GET: /Education/Delete/5
 
        public ActionResult Delete(int id)
        {
            Education education = _db.Educations.Single(x => x.Id == id);
            return View(education);
        }

        //
        // POST: /Education/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Education education = _db.Educations.Single(x => x.Id == id);
            _db.Educations.Remove(education);
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
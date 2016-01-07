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
   public class RefferenceController : Controller
    {
        private CVitaeDb _db = new CVitaeDb();

        //
        // GET: /Refference/

        public ViewResult Index()
        {
            return View(_db.Refferences.ToList());
        }

        //
        // GET: /Refference/Details/5

        public ViewResult Details(int id)
        {
            Refference refference = _db.Refferences.Single(x => x.Id == id);
            return View(refference);
        }

       // GET: UserID

        private int getUserId(int Id)
        {
            //ConnetionConfig.IniciarConexion();
            //int userId = (int)Membership.GetUser().ProviderUserKey;

            var userId =  _db.Users.Find(Id);
            
            return userId.Id;
        }


        //
        // GET: /Refference/Create

        public ActionResult Create()
        {
            ViewBag.PossibleUser = _db.Users;
            return View();
        } 

        //
        // POST: /Refference/Create

        [HttpPost]
        public ActionResult Create(Refference refference)
        {


            if (ModelState.IsValid)
            {
                _db.Refferences.Add(refference);
                _db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleUser = _db.Users;
            return View(refference);
        }
        
        //
        // GET: /Refference/Edit/5
 
        public ActionResult Edit(int id)
        {
            Refference refference = _db.Refferences.Single(x => x.Id == id);
            ViewBag.PossibleUser = _db.Users;
            return View(refference);
        }

        //
        // POST: /Refference/Edit/5

        [HttpPost]
        public ActionResult Edit(Refference refference)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(refference).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleUser = _db.Users;
            return View(refference);
        }

        //
        // GET: /Refference/Delete/5
 
        public ActionResult Delete(int id)
        {
            Refference refference = _db.Refferences.Single(x => x.Id == id);
            return View(refference);
        }

        //
        // POST: /Refference/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Refference refference = _db.Refferences.Single(x => x.Id == id);
            _db.Refferences.Remove(refference);
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
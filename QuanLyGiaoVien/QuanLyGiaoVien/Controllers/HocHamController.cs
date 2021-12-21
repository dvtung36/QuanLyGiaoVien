using QuanLyGiaoVien.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiaoVien.Controllers
{
    public class HocHamController : Controller
    {
        private Model1 db = new Model1();
        // GET: HocHam
        public ActionResult Index()
        {
            var model = db.HOCHAMs.Where(x => x.MaHH != null).ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHH,TenHH,MaDM")] HOCHAM hh)
        {
            if (ModelState.IsValid)
            {
                db.HOCHAMs.Add(hh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hh);
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOCHAM hv = db.HOCHAMs.Find(id);
            if (hv == null)
            {
                return HttpNotFound();
            }
            return View(hv);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HOCHAM hv = db.HOCHAMs.Find(id);
            db.HOCHAMs.Remove(hv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
            }
            HOCHAM hv = db.HOCHAMs.Find(id);
            if (hv == null)
            {
                return HttpNotFound();
            }
            return View(hv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHH,TenHH,MaDM")] HOCHAM hv)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hv).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hv);
        }

    }
}
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
    public class HocViController : Controller
    {
        private Model1 db = new Model1();
        // GET: HocVi
        public ActionResult Index()
        {
            var model = db.HOCVIs.Where(x => x.MaHV != null).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHV,TenHV")] HOCVI hocvi)
        {
            if (ModelState.IsValid)
            {
                db.HOCVIs.Add(hocvi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hocvi);
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOCVI hv = db.HOCVIs.Find(id);
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
            HOCVI hv = db.HOCVIs.Find(id);
            db.HOCVIs.Remove(hv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOCVI hv = db.HOCVIs.Find(id);
            if (hv == null)
            {
                return HttpNotFound();
            }
            return View(hv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHV,TenHV")] HOCVI hv)
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
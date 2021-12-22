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
    public class ChucVuDangController : Controller
    {
        private Model1 db = new Model1();
        // GET: cvd
        public ActionResult Index()
        {
            var model = db.CHUCVUDANGs.Where(x => x.MaCVD != null).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCVD,TenCVD,MaDTMG")] CHUCVUDANG bm)
        {
            if (ModelState.IsValid)
            {
                db.CHUCVUDANGs.Add(bm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bm);
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHUCVUDANG bm = db.CHUCVUDANGs.Find(id);
            if (bm == null)
            {
                return HttpNotFound();
            }
            return View(bm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CHUCVUDANG bm = db.CHUCVUDANGs.Find(id);
            db.CHUCVUDANGs.Remove(bm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHUCVUDANG khoa = db.CHUCVUDANGs.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCVD,TenCVD,MaDTMG")] CHUCVUDANG bm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bm);
        }
    }
}
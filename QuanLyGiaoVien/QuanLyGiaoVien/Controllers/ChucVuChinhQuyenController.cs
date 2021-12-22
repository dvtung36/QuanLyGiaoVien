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
    public class ChucVuChinhQuyenController : Controller
    {
        private Model1 db = new Model1();
        // GET: cvcq
        public ActionResult Index()
        {
            var model = db.CHUCVUCQs.Where(x => x.MaCVCQ != null).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCVCQ,TenCVCQ,MaDTMG")] CHUCVUCQ bm)
        {
            if (ModelState.IsValid)
            {
                db.CHUCVUCQs.Add(bm);
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
            CHUCVUCQ bm = db.CHUCVUCQs.Find(id);
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
            CHUCVUCQ bm = db.CHUCVUCQs.Find(id);
            db.CHUCVUCQs.Remove(bm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHUCVUCQ khoa = db.CHUCVUCQs.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCVCQ,TenCVCQ,MaDTMG")] CHUCVUCQ bm)
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
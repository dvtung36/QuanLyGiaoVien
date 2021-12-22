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
    public class BoMonController : Controller
    {
        private Model1 db = new Model1();
        // GET: BoMon
        public ActionResult Index()
        {
            var model = db.BOMONs.Where(x => x.MaBM != null).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaBM,MaKhoa,TenBM")] BOMON bm)
        {
            if (ModelState.IsValid)
            {
                db.BOMONs.Add(bm);
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
            BOMON bm = db.BOMONs.Find(id);
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
            BOMON bm = db.BOMONs.Find(id);
            db.BOMONs.Remove(bm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOMON khoa = db.BOMONs.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaBM,MaKhoa,TenBM")] BOMON bm)
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
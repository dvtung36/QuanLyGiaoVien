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
    public class LopController : Controller
    {
        private Model1 db = new Model1();
        // GET: Lop
        public ActionResult Index()
        {
            var model = db.LOPs.Where(x => x.MaLop != null).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,MaHP,TenLop,SiSo,HocKy,NamHoc,He")] LOP hh)
        {
            if (ModelState.IsValid)
            {
                db.LOPs.Add(hh);
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
            LOP hv = db.LOPs.Find(id);
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
            LOP hv = db.LOPs.Find(id);
            db.LOPs.Remove(hv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOP hv = db.LOPs.Find(id);
            if (hv == null)
            {
                return HttpNotFound();
            }
            return View(hv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,MaHP,TenLop,SiSo,HocKy,NamHoc,He")] LOP hv)
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
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
    public class GiaoVienController : Controller
    {
        private Model1 db = new Model1();
        // GET: GiaoVien
        public ActionResult Index()
        {
            var model = db.GIAOVIENs.Where(x => x.MaGV != null).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGV,MaBM,TenGV,GioiTinh,NgaySinh,DiaChi,TiLeMG,SDT,Email")] GIAOVIEN hh)
        {
            if (ModelState.IsValid)
            {
                db.GIAOVIENs.Add(hh);
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
            GIAOVIEN hv = db.GIAOVIENs.Find(id);
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
            GIAOVIEN hv = db.GIAOVIENs.Find(id);
            db.GIAOVIENs.Remove(hv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GIAOVIEN hv = db.GIAOVIENs.Find(id);
            if (hv == null)
            {
                return HttpNotFound();
            }
            return View(hv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGV,MaBM,TenGV,GioiTinh,NgaySinh,DiaChi,TiLeMG,SDT,Email")] GIAOVIEN hv)
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
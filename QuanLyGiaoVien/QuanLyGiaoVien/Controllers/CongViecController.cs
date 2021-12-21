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
    public class CongViecController : Controller
    {
        private Model1 db = new Model1();
        // GET: CongViec
        public ActionResult Index()
        {
            var model = db.CONGVIECs.Where(x => x.MaCV != null).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCV,MaLoaiCV,TenCV,SoLuongCV,DonVi,SoLuongTG,VaiTro")] CONGVIEC hh)
        {
            if (ModelState.IsValid)
            {
                db.CONGVIECs.Add(hh);
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
            CONGVIEC hv = db.CONGVIECs.Find(id);
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
            CONGVIEC hv = db.CONGVIECs.Find(id);
            db.CONGVIECs.Remove(hv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONGVIEC hv = db.CONGVIECs.Find(id);
            if (hv == null)
            {
                return HttpNotFound();
            }
            return View(hv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCV,MaLoaiCV,TenCV,SoLuongCV,DonVi,SoLuongTG,VaiTro")] CONGVIEC hv)
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
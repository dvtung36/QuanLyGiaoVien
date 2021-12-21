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
    public class DoiTuongGiangDayController : Controller
    {
        private Model1 db = new Model1();
        // GET: DoiTuongGiangDay
        public ActionResult Index()
        {
            var model = db.DOITUONGGDs.Where(x => x.MaDT != null).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDT,TenDoiTuong")] DOITUONGGD hh)
        {
            if (ModelState.IsValid)
            {
                db.DOITUONGGDs.Add(hh);
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
            DOITUONGGD hv = db.DOITUONGGDs.Find(id);
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
            DOITUONGGD hv = db.DOITUONGGDs.Find(id);
            db.DOITUONGGDs.Remove(hv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOITUONGGD hv = db.DOITUONGGDs.Find(id);
            if (hv == null)
            {
                return HttpNotFound();
            }
            return View(hv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDT,TenDoiTuong")] DOITUONGGD hv)
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
using QuanLyGiaoVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
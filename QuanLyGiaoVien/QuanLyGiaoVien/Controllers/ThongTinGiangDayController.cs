using QuanLyGiaoVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiaoVien.Controllers
{
    public class ThongTinGiangDayController : Controller
    {
        private Model1 db = new Model1();
        // GET: ThongTinGiangDay
        public ActionResult Index()
        {
            var model = db.TTGIANGDAYs.Where(x => x.MaGV != null).ToList();
            return View(model);
        }
    }
}
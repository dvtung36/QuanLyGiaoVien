using QuanLyGiaoVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
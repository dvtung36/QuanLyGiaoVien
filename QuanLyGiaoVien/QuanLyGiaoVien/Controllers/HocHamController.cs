using QuanLyGiaoVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyGiaoVien.Controllers
{
    public class HocHamController : Controller
    {
        private Model1 db = new Model1();
        // GET: HocHam
        public ActionResult Index()
        {
            var model = db.HOCHAMs.Where(x => x.MaHH != null).ToList();
            return View(model);
        }
    }
}
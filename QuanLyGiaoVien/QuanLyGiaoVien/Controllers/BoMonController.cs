using QuanLyGiaoVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
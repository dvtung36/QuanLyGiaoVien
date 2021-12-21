using QuanLyGiaoVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
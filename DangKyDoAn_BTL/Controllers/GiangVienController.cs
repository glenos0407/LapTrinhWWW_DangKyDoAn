using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DangKyDoAn_BTL.Controllers
{
    public class GiangVienController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("ThongTinGiangVien","GiangVien");
        }

        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult ThongTinGiangVien() {
            return View();
        }
    }
}
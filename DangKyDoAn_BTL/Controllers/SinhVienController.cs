using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DangKyDoAn_BTL.Controllers
{
    public class SinhVienController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("ThongTinSinhVien","SinhVien");
        }
        
        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult ThongTinSinhVien()
        {
            return View();
        }
    }
}
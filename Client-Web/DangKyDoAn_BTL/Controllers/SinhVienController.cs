using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;

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

        public ActionResult ThongTinSinhVien(SinhVien sinhVien)
        {
            return View(sinhVien);
        }

        public ActionResult Test(SinhVien sinhVien)
        {
            return View(sinhVien);
        }
    }
}
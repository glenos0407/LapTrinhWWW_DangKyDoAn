using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using DAL;

namespace DangKyDoAn_BTL.Controllers
{
    public class GiangVienController : Controller
    {
        dalGiangVien dalGiangVien;
       
        public ActionResult Index()
        {
            return RedirectToAction("ThongTinGiangVien","GiangVien");
        }

        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult ThongTinGiangVien() {
            //if(Session["IDGiangVien"] == null)
            //{
            //    return RedirectToAction("Login","GiangVien");
            //}
            Session["IDGiangVien"] = 1;
            dalGiangVien = new dalGiangVien();
            GiangVien gv = dalGiangVien.GetGiangVien(Convert.ToInt32(Session["IDGiangVien"]));

            return View(gv);
        }

        [HttpPost]
        public ActionResult ThongTinGiangVien(GiangVien giangVien)
        {
            //if(Session["IDGiangVien"] == null)
            //{
            //    return RedirectToAction("Login","GiangVien");
            //}

            dalGiangVien = new dalGiangVien();
            GiangVien gv = dalGiangVien.GetGiangVien(Convert.ToInt32(Session["IDGiangVien"]));

            return View(gv);
        }
    }
}
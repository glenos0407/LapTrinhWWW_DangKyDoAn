using Entities;
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

        public ActionResult ThongTinGiangVien() {
            //if(Session["IDGiangVien"] == null)
            //{
            //    return RedirectToAction("Login","GiangVien");
            //}
            //Session["IDGiangVien"] = 1;
            //giangVienDAL = new GiangVienDAL();
            //GiangVien gv = giangVienDAL.GetGiangVien(Convert.ToInt32(Session["IDGiangVien"]));

            return View();
        }

        [HttpPost]
        public ActionResult ThongTinGiangVien(GiangVien gv)
        {
            //if(Session["IDGiangVien"] == null)
            //{
            //    return RedirectToAction("Login","GiangVien");
            //}

            //giangVienDAL = new GiangVienDAL();
            //GiangVien gv = giangVienDAL.GetGiangVien(Convert.ToInt32(Session["IDGiangVien"]));

            return View(gv);
        }
    }
}
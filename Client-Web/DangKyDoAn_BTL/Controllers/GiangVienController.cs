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
            var user = Session["user"] as SinhVien;
            return View(user);
        }

        public ActionResult InforGiangVien() 
        {


            return View();
        }
    }
}
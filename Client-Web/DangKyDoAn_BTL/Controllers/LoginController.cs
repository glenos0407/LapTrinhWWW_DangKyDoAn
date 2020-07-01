using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DangKyDoAn_BTL.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginSinhVien()
        {
            return View();
        }
        public ActionResult LoginGiangVien()
        {
            return View();
        }
        public ActionResult LoginAdmin()
        {
            return View();
        }
    }
}
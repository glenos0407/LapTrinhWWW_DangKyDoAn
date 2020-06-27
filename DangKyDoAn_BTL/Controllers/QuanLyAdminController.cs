using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities;

namespace DangKyDoAn_BTL.Controllers
{
    public class QuanLyAdminController : Controller
    {
        //
        // GET: /QuanLyAdmin/
        public ActionResult Index()
        {
            List<Admin> list = new List<Admin>();
            Admin sv;
            for (int i = 0; i < 50; i++)
            {
                sv = new Admin();
                sv.idAdmin = i;
                sv.hoTen = "Nguyễn Admin 0" + i;
                sv.password = i.ToString();
                sv.email = i + "_Admin@gmail.com";
                sv.soDienThoai = i.ToString();
                sv.khoa = "CNTT_Admin";
                sv.chucVu = i.ToString();
                list.Add(sv);
            }
            //return View(db.Admins.OrderByDescending(n => n.idAdmin));
            return View(list);
        }
        [HttpGet]
        public ActionResult TaoMoiAdmin()
        {
            return View();
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult TaoMoiAdmin(Admin sv)
        {
            //db.Admins.AddObject(sv);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public ActionResult ChinhSuaAdmin(int? IdAdmin)
        {
            //if (IdAdmin == null)
            //{
            //    Response.StatusCode = 404;
            //    return null;
            //}
            //Admin sv = db.Admins.SingleOrDefault(n => n.idAdmin == IdAdmin);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(sv);
            //return RedirectToAction("Index");

            Admin sv = new Admin();
            int i = 999;
            sv.idAdmin = i;
            sv.hoTen = "Nguyễn Admin 0" + i;
            sv.password = i.ToString();
            sv.email = i + "_Admin@gmail.com";
            sv.soDienThoai = i.ToString();
            sv.khoa = "CNTT_Admin";
            sv.chucVu = i.ToString();
            return View(sv);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult ChinhSuaAdmin(Admin model)
        {
            //db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public ActionResult XoaAdmin(int? IdAdmin)
        {
            //if (IdAdmin == null)
            //{
            //    Response.StatusCode = 404;
            //    return null;
            //}
            //Admin sv = db.Admins.SingleOrDefault(n => n.idAdmin == IdAdmin);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(sv);
            //return RedirectToAction("Index");

            Admin sv = new Admin();
            int i = 999;
            sv.idAdmin = i;
            sv.hoTen = "Nguyễn Admin 0" + i;
            sv.password = i.ToString();
            sv.email = i + "_Admin@gmail.com";
            sv.soDienThoai = i.ToString();
            sv.khoa = "CNTT_Admin";
            sv.chucVu = i.ToString();
            return View(sv);
        }
        [HttpPost]
        public ActionResult XoaAdmin(Admin model)
        {
            //if (IdAdmin == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Admin sv = db.Admins.SingleOrDefault(n => n.idAdmin == model.idAdmin);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //db.Admins.Remove(sv);
            //db.SaveChanges();
            //return RedirectToAction("Index");

            return View();
        }
    }
}
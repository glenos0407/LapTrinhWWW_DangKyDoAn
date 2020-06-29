using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities;

namespace DangKyDoAn_BTL.Controllers
{
    public class QuanLyGiangVienController : Controller
    {
        //
        // GET: /QuanLyGiangVien/
        public ActionResult Index()
        {
            List<GiangVien> list = new List<GiangVien>();
            GiangVien sv;
            for (int i = 0; i < 50; i++)
            {
                sv = new GiangVien();
                sv.idGiangVien = i;
                sv.hoTen = "Nguyễn Giảng Viên 0" + i;
                sv.password = i.ToString();
                sv.email = i + "_GiangVien@gmail.com";
                sv.diaChi = "Đường " + i;
                sv.soDienThoai = i.ToString();
                sv.chucVu = i.ToString();
                sv.khoa = "CNTT_GiangVien";
                list.Add(sv);
            }
            //return View(db.GiangViens.OrderByDescending(n => n.idGiangVien));
            return View(list);
        }
        [HttpGet]
        public ActionResult TaoMoiGiangVien()
        {
            return View();
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult TaoMoiGiangVien(GiangVien sv)
        {
            //db.GiangViens.AddObject(sv);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public ActionResult ChinhSuaGiangVien(int IdGiangVien)
        {
            //if (IdGiangVien == null)
            //{
            //    Response.StatusCode = 404;
            //    return null;
            //}
            //GiangVien sv = db.GiangViens.SingleOrDefault(n => n.idGiangVien == IdGiangVien);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(sv);

            GiangVien sv = new GiangVien();
            int i = 999;
            sv.idGiangVien = i;
            sv.hoTen = "Nguyễn Giảng Viên 0" + i;
            sv.password = i.ToString();
            sv.email = i + "_GiangVien@gmail.com";
            sv.diaChi = "Đường " + i;
            sv.soDienThoai = i.ToString();
            sv.chucVu = i.ToString();
            sv.khoa = "CNTT_GiangVien";
            return View(sv);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult ChinhSuaGiangVien(GiangVien model)
        {
            //db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public ActionResult XoaGiangVien(int? IdGiangVien)
        {
            //if (IdGiangVien == null)
            //{
            //    Response.StatusCode = 404;
            //    return null;
            //}
            //GiangVien sv = db.GiangViens.SingleOrDefault(n => n.idGiangVien == IdGiangVien);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(sv);

            GiangVien sv = new GiangVien();
            int i = 999;
            sv.idGiangVien = i;
            sv.hoTen = "Nguyễn Giảng Viên 0" + i;
            sv.password = i.ToString();
            sv.email = i + "_GiangVien@gmail.com";
            sv.diaChi = "Đường " + i;
            sv.soDienThoai = i.ToString();
            sv.chucVu = i.ToString();
            sv.khoa = "CNTT_GiangVien";
            return View(sv);
        }
        [HttpPost]
        public ActionResult XoaGiangVien(GiangVien model)
        {
            //if (IdGiangVien == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //GiangVien sv = db.GiangViens.SingleOrDefault(n => n.idGiangVien == model.idGiangVien);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //db.GiangViens.Remove(sv);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
    }
}
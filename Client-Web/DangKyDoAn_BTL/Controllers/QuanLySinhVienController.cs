using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities;

namespace DangKyDoAn_BTL.Controllers
{
    public class QuanLySinhVienController : Controller
    {
        //
        // GET: /QuanLySinhVien/
        public ActionResult Index()
        {
            List<SinhVien> list = new List<SinhVien>();
            SinhVien sv;
            for (int i = 0; i < 50; i++)
            {
                sv = new SinhVien();
                sv.idSinhVien = i;
                sv.hoTenSinhVien = "Nguyễn Sinh Viên 0" + i;
                sv.password = i.ToString();
                sv.nienKhoa = i.ToString();
                sv.diaChi = "Đường " + i;
                sv.soDienThoai = i.ToString();
                sv.email = i + "_SinhVien@gmail.com";
                sv.khoa = "CNTT_SinhVien";
                list.Add(sv);
            }
            //return View(db.SinhViens.OrderByDescending(n => n.idSinhVien));
            return View(list);
        }
        [HttpGet]
        public ActionResult TaoMoiSinhVien()
        {
            return View();
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult TaoMoiSinhVien(SinhVien sv)
        {
            //db.SinhViens.AddObject(sv);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public ActionResult ChinhSuaSinhVien(int IdSinhVien)
        {
            //if (IdSinhVien == null)
            //{
            //    Response.StatusCode = 404;
            //    return null;
            //}
            //SinhVien sv = db.SinhViens.SingleOrDefault(n => n.idSinhVien == IdSinhVien);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(sv);

            SinhVien sv = new SinhVien();
            int i = 999;
            sv.idSinhVien = i;
            sv.hoTenSinhVien = "Nguyễn Sinh Viên 0" + i;
            sv.password = i.ToString();
            sv.nienKhoa = i.ToString();
            sv.diaChi = "Đường " + i;
            sv.soDienThoai = i.ToString();
            sv.email = i + "_SinhVien@gmail.com";
            sv.khoa = "CNTT_SinhVien";
            return View(sv);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult ChinhSuaSinhVien(SinhVien model)
        {
            //db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public ActionResult XoaSinhVien(int IdSinhVien)
        {
            //if (IdSinhVien == null)
            //{
            //    Response.StatusCode = 404;
            //    return null;
            //}
            //SinhVien sv = db.SinhViens.SingleOrDefault(n => n.idSinhVien == IdSinhVien);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(sv);

            SinhVien sv = new SinhVien();
            int i = 999;
            sv.idSinhVien = i;
            sv.hoTenSinhVien = "Nguyễn Sinh Viên 0" + i;
            sv.password = i.ToString();
            sv.nienKhoa = i.ToString();
            sv.diaChi = "Đường " + i;
            sv.soDienThoai = i.ToString();
            sv.email = i + "_SinhVien@gmail.com";
            sv.khoa = "CNTT_SinhVien";
            return View(sv);
        }
        [HttpPost]
        public ActionResult XoaSinhVien(SinhVien model)
        {
            //if (IdSinhVien == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //SinhVien sv = db.SinhViens.SingleOrDefault(n => n.idSinhVien == model.idSinhVien);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //db.SinhViens.Remove(sv);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
    }
}
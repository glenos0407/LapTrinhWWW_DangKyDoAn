using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities;

namespace DangKyDoAn_BTL.Controllers
{
    public class QuanLyDoAnController : Controller
    {
        //
        // GET: /QuanLyDoAn/
        public ActionResult Index()
        {
            List<DoAn> list = new List<DoAn>();
            DoAn sv;
            for (int i = 0; i < 50; i++)
            {
                sv = new DoAn();
                sv.idDoAn = i;
                sv.tenDoAn = "Đồ án 0" + i;
                sv.noiDung = i.ToString();
                sv.khoaHoc = i.ToString();
                sv.khoa = "CNTT_DoAn";
                list.Add(sv);
            }
            //return View(db.DoAns.OrderByDescending(n => n.idDoAn));
            return View(list);
        }
        [HttpGet]
        public ActionResult TaoMoiDoAn()
        {
            return View();
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult TaoMoiDoAn(DoAn sv)
        {
            //db.DoAns.AddObject(sv);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public ActionResult ChinhSuaDoAn(int IdDoAn)
        {
            //if (IdDoAn == null)
            //{
            //    Response.StatusCode = 404;
            //    return null;
            //}
            //DoAn sv = db.DoAns.SingleOrDefault(n => n.idDoAn == IdDoAn);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(sv);

            DoAn sv = new DoAn();
            int i = 999;
            sv.idDoAn = i;
            sv.tenDoAn = "Đồ án 0" + i;
            sv.noiDung = i.ToString();
            sv.khoaHoc = i.ToString();
            sv.khoa = "CNTT_DoAn";
            return View(sv);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult ChinhSuaDoAn(DoAn model)
        {
            //db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public ActionResult XoaDoAn(int IdDoAn)
        {
            //if (IdDoAn == null)
            //{
            //    Response.StatusCode = 404;
            //    return null;
            //}
            //DoAn sv = db.DoAns.SingleOrDefault(n => n.idDoAn == IdDoAn);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(sv);

            DoAn sv = new DoAn();
            int i = 999;
            sv.idDoAn = i;
            sv.tenDoAn = "Đồ án 0" + i;
            sv.noiDung = i.ToString();
            sv.khoaHoc = i.ToString();
            sv.khoa = "CNTT_DoAn";
            return View(sv);
        }
        [HttpPost]
        public ActionResult XoaDoAn(DoAn model)
        {
            //if (IdDoAn == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //DoAn sv = db.DoAns.SingleOrDefault(n => n.idDoAn == model.idDoAn);
            //if (sv == null)
            //{
            //    return HttpNotFound();
            //}
            //db.DoAns.Remove(sv);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }
    }
}
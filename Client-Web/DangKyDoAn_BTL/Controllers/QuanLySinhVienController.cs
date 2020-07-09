using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Entities;
using Newtonsoft.Json;

namespace DangKyDoAn_BTL.Controllers
{
    public class QuanLySinhVienController : Controller
    {
        private const string URL = "https://localhost:44330/";
        static HttpClient client;

        public QuanLySinhVienController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        private async Task<string> GetAll()
        {
            var response = client.GetAsync("api/SinhVien/GetAll").Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }
        private async Task<string> GetAdminById(int id)
        {
            var response = client.GetAsync("api/Admin/GetById?Id=" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }
        //
        // GET: /QuanLySinhVien/
        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                if (Session["user"] is Admin)
                {
                    int id = (Session["user"] as Admin).idAdmin;
                    var result = GetAdminById(id).GetAwaiter().GetResult();
                    Session["user"] = JsonConvert.DeserializeObject<Admin>(result.ToString());

                    var json = GetAll().GetAwaiter().GetResult();
                    var listAdmin = JsonConvert.DeserializeObject<List<SinhVien>>(json.ToString());
                    return View(listAdmin);
                }
                return RedirectToAction("LoginSinhVien", "Login");
            }
            else
            {
                return RedirectToAction("LoginSinhVien", "Login");
            }
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
            sv.hoTen = "Nguyễn Sinh Viên 0" + i;
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
            sv.hoTen = "Nguyễn Sinh Viên 0" + i;
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
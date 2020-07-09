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
    public class QuanLyAdminController : Controller
    {
        private const string URL = "https://localhost:44330/";
        static HttpClient client;

        public QuanLyAdminController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        private async Task<string> GetById(int idDoAn)
        {
            var response = client.GetAsync("api/DoAn/GetById?Id=" + idDoAn).Result;
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

        private async Task<string> GetAll()
        {
            var response = client.GetAsync("api/DoAn/GetAll").Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }
        //
        // GET: /QuanLyAdmin/
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
                    var listAdmin = JsonConvert.DeserializeObject<List<Admin>>(json.ToString());
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
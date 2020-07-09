using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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
        private async Task<string> Add(SinhVien sv)
        {
            string contentString =
                            "{ \"idSinhVien\" : " + 0 + "," +
                            "\"hoTen\": \"" + sv.hoTen + "\"," +
                            "\"password\": \"" + sv.password + "\"," +
                            "\"avatarLink\": \"" + sv.avatarLink + "\"," +
                            "\"nienKhoa\": \"" + sv.email + "\"," +
                            "\"diaChi\": \"" + sv.diaChi + "\"," +
                            "\"soDienThoai\": \"" + sv.soDienThoai + "\"," +
                            "\"avatarLink\": \"" + sv.avatarLink + "\"," +
                            "\"email\": \"" + sv.email + "\"," +
                            "\"khoa\": \"" + sv.khoa + "\"," +
                            "\"idDoAn\": " + "null" + "}" +
                            "\"DoAns\": " + "null" + "}";
            var content = new StringContent(contentString, Encoding.UTF8, "application/json");
            var response = client.GetAsync("api/SinhVien/Add", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }
        private async Task<string> Update(SinhVien sv)
        {
            string contentString =
                            "{ \"idSinhVien\" : " + sv.idSinhVien + "," +
                            "\"hoTen\": \"" + sv.hoTen + "\"," +
                            "\"password\": \"" + sv.password + "\"," +
                            "\"avatarLink\": \"" + sv.avatarLink + "\"," +
                            "\"nienKhoa\": \"" + sv.email + "\"," +
                            "\"diaChi\": \"" + sv.diaChi + "\"," +
                            "\"soDienThoai\": \"" + sv.soDienThoai + "\"," +
                            "\"avatarLink\": \"" + sv.avatarLink + "\"," +
                            "\"email\": \"" + sv.email + "\"," +
                            "\"khoa\": \"" + sv.khoa + "\"," +
                            "\"idDoAn\": " + "null" + "}" +
                            "\"DoAns\": " + "null" + "}";
            var content = new StringContent(contentString, Encoding.UTF8, "application/json");

            var response = client.PostAsync("api/SinhVien/Update", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }
        private async Task<string> GetById(int id)
        {
            var response = client.GetAsync("api/SinhVien/GetById" + id).Result;
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
            var json = Add(sv).GetAwaiter().GetResult();
            var result = JsonConvert.DeserializeObject<SinhVien>(json.ToString());
            return View(result);
        }
        [HttpGet]
        public ActionResult ChinhSuaSinhVien(int IdSinhVien)
        {
            SinhVien sv = JsonConvert.DeserializeObject<SinhVien>(GetById(IdSinhVien).GetAwaiter().GetResult().ToString());
            return View(sv);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult ChinhSuaSinhVien(SinhVien model)
        {
            var json = Update(model).GetAwaiter().GetResult();
            var result = JsonConvert.DeserializeObject<SinhVien>(json.ToString());
            return View(result);
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

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
    public class QuanLyGiangVienController : Controller
    {
        private const string URL = "https://localhost:44330/";
        static HttpClient client;

        public QuanLyGiangVienController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async Task<string> AddGiangVien(GiangVien gv)
        {
            string contentString =
                "{ \"idGiangVien\" : " + 0 + "," +
                "\"hoTen\": \"" + gv.hoTen + "\"," +
                "\"password\": \"" + gv.password + "\"," +
                "\"avatarLink\": \"" + gv.avatarLink + "\"," +
                "\"email\": \"" + gv.email + "\"," +
                "\"diaChi\": \"" + gv.diaChi + "\"," +
                "\"soDienThoai\": \"" + gv.soDienThoai + "\"," +
                "\"chucVu\": \"" + gv.chucVu + "\"," +
                "\"khoa\": \"" + gv.khoa + "\"," +
                "\"DoAns\": " + "null" + "}";
            var content = new StringContent(contentString, Encoding.UTF8, "application/json");

            var response = client.PostAsync("api/GiangVien/Add", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }
        
        private async Task<string> UpdateGiangVien(GiangVien gv)
        {
            string contentString =
                "{ \"idGiangVien\" : " + gv.idGiangVien + "," +
                "\"hoTen\": \"" + gv.hoTen + "\"," +
                "\"password\": \"" + gv.password + "\"," +
                "\"avatarLink\": \"" + gv.avatarLink + "\"," +
                "\"email\": \"" + gv.email + "\"," +
                "\"diaChi\": \"" + gv.diaChi + "\"," +
                "\"soDienThoai\": \"" + gv.soDienThoai + "\"," +
                "\"chucVu\": \"" + gv.chucVu + "\"," +
                "\"khoa\": \"" + gv.khoa + "\"," +
                "\"DoAns\": " + "null" + "}";
            var content = new StringContent(contentString, Encoding.UTF8, "application/json");

            var response = client.PostAsync("api/GiangVien/Update", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }
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
        public ActionResult TaoMoiGiangVien(GiangVien gv)
        {
            var json = AddGiangVien(gv).GetAwaiter().GetResult();
            var result = JsonConvert.DeserializeObject<GiangVien>(json.ToString());
            return View(result);
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
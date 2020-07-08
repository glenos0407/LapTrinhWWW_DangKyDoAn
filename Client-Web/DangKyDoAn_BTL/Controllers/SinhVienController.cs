using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Entities;
using Newtonsoft.Json;

namespace DangKyDoAn_BTL.Controllers
{
    public class SinhVienController : Controller
    {
        private const string URL = "https://localhost:44330/";
        static HttpClient client;

        public SinhVienController()
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

        private async Task<string> GetSinhVienById(int id)
        {
            var response = client.GetAsync("api/SinhVien/GetById?Id=" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }

        //public ActionResult SinhVienEditing(int id)
        //{
        //    var result = GetSinhVienById(id).GetAwaiter().GetResult();
        //    Session["user"] = JsonConvert.DeserializeObject<SinhVien>(result.ToString());
        //    return View("Index");
        //}
        public ActionResult Index()
        {
            if(Session["user"] != null)
            {
                int id = (Session["user"] as SinhVien).idSinhVien;
                var result = GetSinhVienById(id).GetAwaiter().GetResult();
                Session["user"] = JsonConvert.DeserializeObject<SinhVien>(result.ToString());
                var user = Session["user"] as SinhVien;
                return View(user);
            }
            else
            {
                return RedirectToAction("LoginSinhVien", "Login");
            }
        }
        public ActionResult DetailDoAn(int id)
        {
            if(Session["user"] != null)
            {
                var result = GetById(id).GetAwaiter().GetResult();
                var doAn = JsonConvert.DeserializeObject<DoAn>(result.ToString());
                ViewBag.idDoAn = doAn.idDoAn;
                return View(doAn);
            }
            return RedirectToAction("LoginSinhVien", "Login");
        } 
    }
}
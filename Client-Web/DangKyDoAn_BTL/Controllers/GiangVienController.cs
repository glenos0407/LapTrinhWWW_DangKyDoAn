using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DangKyDoAn_BTL.Controllers
{
    public class GiangVienController : Controller
    {
        private const string URL = "https://localhost:44330/";
        static HttpClient client;

        public GiangVienController()
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

        private async Task<string> GetGiangVienById(int id)
        {
            var response = client.GetAsync("api/GiangVien/GetById?Id=" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }

        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                if(Session["user"] is GiangVien)
                {
                    int id = (Session["user"] as GiangVien).idGiangVien;
                    var result = GetGiangVienById(id).GetAwaiter().GetResult();
                    Session["user"] = JsonConvert.DeserializeObject<GiangVien>(result.ToString());
                    var user = Session["user"] as GiangVien;
                    return View(user);
                }
                else
                {
                    return RedirectToAction("Index", "SinhVien");
                }
            }
            else
            {
                return RedirectToAction("LoginGiangVien","Login");
            }
        }

        public ActionResult DetailDoAn(int id)
        {
            if(Session["user"] != null)
            {
                if (Session["user"] is GiangVien)
                {
                    var result = GetById(id).GetAwaiter().GetResult();
                    var doAn = JsonConvert.DeserializeObject<DoAn>(result.ToString());
                    ViewBag.idDoAn = doAn.idDoAn;
                    return View(doAn);
                }
                else
                {
                    return RedirectToAction("Index", "SinhVien");
                }
            }
            else
            {
                return RedirectToAction("LoginGiangVien", "Login");
            }
        }
    }
}
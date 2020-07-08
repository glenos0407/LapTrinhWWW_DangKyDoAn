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

        public ActionResult Index()
        {
            var user = Session["user"] as SinhVien;
            return View(user);
        }
        public ActionResult DetailDoAn(int id)
        {
            var result = GetById(id).GetAwaiter().GetResult();
            var doAn = JsonConvert.DeserializeObject<DoAn>(result.ToString());
            ViewBag.idDoAn = doAn.idDoAn;
            return View(doAn);
        } 
    }
}
using Entities;
using Entities.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DangKyDoAn_BTL.Controllers
{
    public class LoginController : Controller
    {
        private const string URL = "https://localhost:44330/";
        static HttpClient client;
        public LoginController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #region method
        private async Task<string> GetById(LoginDto dto, string user)
        {
            string contentString = "{ \"id\" : " + dto.id + "," +
                "\"password\": \"" + dto.password + "\"}";
            var content = new StringContent(contentString, Encoding.UTF8, "application/json");

            var response = client.PostAsync("api/" + user + "/Login", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }
        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "No network adapters with an IPv4 address in the system!";
        }
        #endregion

        #region Login SinhVien
        public ActionResult LoginSinhVien()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginSinhVien(LoginDto dto)
        {
            var result = GetById(dto, "SinhVien").GetAwaiter().GetResult();
            var sinhVien = JsonConvert.DeserializeObject<SinhVien>(result.ToString());
            if (sinhVien != null)
            {
                Session["user"] = sinhVien;
                return RedirectToAction("Index", "SinhVien", sinhVien.idSinhVien);
            }
            else
                return View("LoginSinhVien");
        }
        #endregion

        #region Login GiangVien
        public ActionResult LoginGiangVien()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginGiangVien(LoginDto dto)
        {
            var result = GetById(dto, "GiangVien").GetAwaiter().GetResult();
            var giangVien = JsonConvert.DeserializeObject<GiangVien>(result.ToString());
            if (giangVien != null)
            {
                Session["user"] = giangVien;
                return RedirectToAction("Index", "GiangVien", giangVien.idGiangVien);
            }
            else
                return View("LoginGiangVien");
        }
        #endregion

        #region Login Admin
        public ActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginAdmin(LoginDto dto)
        {
            var result = GetById(dto, "Admin").GetAwaiter().GetResult();
            var admin = JsonConvert.DeserializeObject<Admin>(result.ToString());
            if (admin != null)
            {
                Session["user"] = admin;
                return RedirectToAction("Index", "Admin", admin.idAdmin);
            }
            else
                return View("LoginGiangVien");
        }
        #endregion

        public ActionResult Logout(string check)
        {
            Session["user"] = null;
            return View("LoginSinhVien");
        }
    }
}
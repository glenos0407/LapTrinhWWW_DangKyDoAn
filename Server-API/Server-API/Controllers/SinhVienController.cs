using Model.Entities;
using Service;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace Server_API.Controllers
{
    public class SinhVienController : ApiController
    {
        private ISinhVienService sinhVienService;

        public SinhVienController()
        {
            sinhVienService = new SinhVienService();
        }
        [Route("api/SinhVien/GetAll")]
        public IHttpActionResult GetAll()
        {
            return Json(sinhVienService.GetAll());
        }
        [Route("api/SinhVien/GetById")]
        public IHttpActionResult GetById(int id)
        {
            return Json(sinhVienService.GetById(id));
            //var user = HttpContext.Current.Session["SV" + id] as SinhVien;
            //return Json(user);
        }
        [Route("api/SinhVien/Add")]
        public IHttpActionResult Add(SinhVien sinhVien)
        {
            return Json(sinhVienService.Add(sinhVien));
        }
        [Route("api/SinhVien/Delete")]
        public IHttpActionResult Delete(int id)
        {
            return Json(sinhVienService.Delete(id));
        }
        [Route("api/SinhVien/GetName")]
        public IHttpActionResult GetName(int id)
        {
            return Json(sinhVienService.GetName(id));
        }
        [Route("api/SinhVien/Login")]
        public IHttpActionResult Login(LoginDto dto)
        {
            return Json(sinhVienService.Login(dto.id, dto.password));
        }
        [Route("api/SinhVien/Update")]
        public IHttpActionResult Update(SinhVien sv)
        {
            return Json(sinhVienService.Update(sv));
        }
        [Route("api/SinhVien/DangKyDoAn")]
        public IHttpActionResult DangKyDoAn(DangKyDoAnDto dto)
        {
            return Json(sinhVienService.DangKyDoAn(dto.idSinhVien,dto.idDoAn));
        }
        [Route("api/SinhVien/HuyDoAn")]
        public IHttpActionResult HuyDoAn(int id)
        {
            return Json(sinhVienService.HuyDoAn(id));
        }
        
        [Route("api/SinhVien/UpdateDiem")]
        public IHttpActionResult UpdateDiem(int id, double diem)
        {
            return Json(sinhVienService.UpdateDiem(id,diem));
        }
        
        [Route("api/SinhVien/GetSinhVienByIdDoAn")]
        public IHttpActionResult GetSinhVienByIdDoAn(int id)
        {
            return Json(sinhVienService.GetSinhVienByIdDoAn(id));
        }
    }
}

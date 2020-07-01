using Model.Entities;
using Service;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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


    }
}

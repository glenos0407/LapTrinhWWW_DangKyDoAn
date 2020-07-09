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
    public class GiangVienController : ApiController
    {
        private IGiangVienService giangVienService;

        public GiangVienController()
        {
            giangVienService = new GiangVienService();
        }
        [Route("api/GiangVien/Add")]
        public IHttpActionResult Add(GiangVien giangVien)
        {
            return Json(giangVienService.Add(giangVien));
        }
        [Route("api/GiangVien/Delete")]
        public IHttpActionResult Delete(int id)
        {
            return Json(giangVienService.Delete(id));
        }
        [Route("api/GiangVien/GetAll")]
        public IHttpActionResult GetAll()
        {
            return Json(giangVienService.GetAll());
        }
        [Route("api/GiangVien/GetById")]
        public IHttpActionResult GetById(int id)
        {
            return Json(giangVienService.GetById(id));
        }
        [Route("api/GiangVien/GetName")]
        public IHttpActionResult GetName(int id)
        {
            return Json(giangVienService.GetName(id));
        }
        [Route("api/GiangVien/Update")]
        public IHttpActionResult Update(GiangVien giangVien)
        {
            return Json(giangVienService.Update(giangVien));
        }
        [Route("api/GiangVien/Login")]
        public IHttpActionResult Login(LoginDto dto)
        {
            return Json(giangVienService.Login(dto.id, dto.password));
        }
    }
    // Data Transfer Object
}

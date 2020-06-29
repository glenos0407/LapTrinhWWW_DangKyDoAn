using Service;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model.Entities;

namespace Server_API.Controllers
{
    public class DoAnController : ApiController
    {
        private IDoAnService doAnService;

        public DoAnController()
        {
            doAnService = new DoAnService();
        }
        [Route("api/DoAn/Add")]
        public IHttpActionResult Add(DoAn doAn)
        {
            return Json(doAnService.Add(doAn));
        }
        [Route("api/DoAn/Delete")]
        public IHttpActionResult Delete(int id)
        {
            return Json(doAnService.Delete(id));
        }
        [Route("api/DoAn/GetAll")]
        public IHttpActionResult GetAll()
        {
            return Json(doAnService.GetAll());
        }
        [Route("api/DoAn/GetById")]
        public IHttpActionResult GetById(int id)
        {
            return Json(doAnService.GetById(id));
        }
        [Route("api/DoAn/GetName")]
        public IHttpActionResult GetName(int id)
        {
            return Json(doAnService.GetName(id));
        }
        [Route("api/DoAn/Update")]
        public IHttpActionResult Update(DoAn doAn)
        {
            return Json(doAnService.Update(doAn));
        }
        [Route("api/DoAn/GetID")]
        public IHttpActionResult GetID(string name)
        {
            return Json(doAnService.GetID(name));
        }
        [Route("api/DoAn/GetDoAnByIDGiangVien")]
        public IHttpActionResult GetDoAnByIDGiangVien(int id)
        {
            return Json(doAnService.GetDoAnByIDGiangVien(id));
        }
    }
}

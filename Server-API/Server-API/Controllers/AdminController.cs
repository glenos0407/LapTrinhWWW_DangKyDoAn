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
    public class AdminController : ApiController
    {
        private IAdminService adminService;

        public AdminController()
        {
            adminService = new AdminService();
        }
        [Route("api/admin/Add")]
        public IHttpActionResult Add(Admin admin)
        {
            return Json(adminService.Add(admin));
        }
        [Route("api/admin/Delete")]
        public IHttpActionResult Delete(int id)
        {
            return Json(adminService.Delete(id));
        }
        [Route("api/admin/GetAll")]
        public IHttpActionResult GetAll()
        {
            return Json(adminService.GetAll());
        }
        [Route("api/admin/GetById")]
        public IHttpActionResult GetById(int id)
        {
            return Json(adminService.GetById(id));
        }
        [Route("api/admin/GetName")]
        public IHttpActionResult GetName(int id)
        {
            return Json(adminService.GetName(id));
        }
        [Route("api/admin/Update")]
        public IHttpActionResult Update(Admin admin)
        {
            return Json(adminService.Update(admin));
        }
        [Route("api/admin/GetID")]
        public IHttpActionResult GetID(string name)
        {
            return Json(adminService.GetID(name));
        }

        [Route("api/admin/Login")]
        public IHttpActionResult Login(LoginDto dto)
        {
            return Json(adminService.Login(dto.id,dto.password));
        }
    }
}

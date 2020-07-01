using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Service.Interface
{
    public interface IAdminService : IBaseService<Admin>
    {
        int GetID (string hoTen);
        Admin Login(int idAdmin, string password);
    }
}

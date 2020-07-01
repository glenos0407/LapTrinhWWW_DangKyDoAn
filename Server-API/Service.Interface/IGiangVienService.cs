using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IGiangVienService : IBaseService<GiangVien>
    {
        GiangVien Login(int idGiangVien, string password);
    }
}

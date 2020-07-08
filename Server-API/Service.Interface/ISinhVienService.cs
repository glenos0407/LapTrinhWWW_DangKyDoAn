using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ISinhVienService : IBaseService<SinhVien>
    {
        SinhVien Login(int idSinhVien, string password);
        SinhVien HuyDoAn(int id);
        SinhVien DangKyDoAn(int idSinhVien, int idDoAn);
        bool UpdateDiem(int id, double diem);
        IEnumerable<SinhVienDiemDto> GetSinhVienByIdDoAn(int idDoAn);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class SinhVienDAL
    {
        DangKyDoAn_DBContext db;
        public SinhVienDAL()
        {
            db = new DangKyDoAn_DBContext();
        }
        public SinhVien GetSinhVien(int id)
        {
            return db.SinhViens.FirstOrDefault(sv => sv.idSinhVien == id);
        }
        public string GetHoTenSinhVien(int id)
        {
            return db.SinhViens.FirstOrDefault(sv => sv.idSinhVien == id).hoTenSinhVien;
        }
        public bool SuaTTSinhVien(SinhVien sv)
        {
            try
            {
                SinhVien sinhvien = db.SinhViens.FirstOrDefault(x => x.idSinhVien == sv.idSinhVien);
                sinhvien.diaChi = sv.diaChi;
                sinhvien.soDienThoai = sv.soDienThoai;
                sinhvien.email = sv.email;
                db.SaveChanges();

            }
            catch 
            {
                return false;
            }
            return true;
        }
    }
}

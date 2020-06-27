using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class dalGiangVien
    {
        DangKyDoAn_DBContext db;

        public dalGiangVien()
        {
            db = new DangKyDoAn_DBContext();
        }

        public string GetHoTen(int id)
        {
            return db.GiangViens.FirstOrDefault(gv => gv.idGiangVien == id).hoTen;
        }

        public int GetID(string hoTen)
        {
            return db.GiangViens.FirstOrDefault(gv => gv.hoTen.Equals(hoTen)).idGiangVien;
        }

        public GiangVien GetGiangVien(int id)
        {
            return db.GiangViens.FirstOrDefault(gv => gv.idGiangVien == id);
        }
    }
}

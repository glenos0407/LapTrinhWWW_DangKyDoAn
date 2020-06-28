using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DoAnDAL
    {
        DangKyDoAn_DBContext db;
        public DoAnDAL()
        {
            db = new DangKyDoAn_DBContext();
        }
        public string GetTenDoAn(int id)
        {
            return db.DoAns.FirstOrDefault(da => da.idDoAn == id).tenDoAn;
        }
        public int GetID(string tendoan)
        {
            return db.DoAns.FirstOrDefault(da => da.tenDoAn.Equals(tendoan)).idDoAn;
        }
        public DoAn GetDoAn(int id)
        {
            return db.DoAns.FirstOrDefault(da => da.idDoAn == id);
        }
        public List<DoAn> getallDoAn()
        {
            var listdoan = (from x in db.DoAns select x).ToList();
            List<DoAn> ld = new List<DoAn>();
            foreach (DoAn item in listdoan)
            {
                DoAn d = new DoAn();
                d.idDoAn = item.idDoAn;
                d.tenDoAn = item.tenDoAn;
                d.noiDung = item.noiDung;
                d.khoaHoc = item.khoaHoc;
                d.khoa = item.khoa;
                d.idGiangVien = item.idGiangVien;
           
                ld.Add(d);
            }
            return ld;
        }
        public DoAn gettDoAn_byID(int id)
        {
            DoAn doan = new DoAn();
            DoAn da = (from x in db.DoAns where x.idDoAn.Equals(id) select x).SingleOrDefault();
            doan.idDoAn = doan.idDoAn;
            doan.tenDoAn = doan.tenDoAn;
            doan.noiDung = doan.noiDung;
            doan.khoaHoc = doan.khoaHoc;
            doan.khoa = doan.khoa;
            doan.idGiangVien = doan.idGiangVien;
            return doan;

        }
        public DoAn gettDoAn_byIDGiangVien(int idgiangvien)
        {
            DoAn doan = new DoAn();
            DoAn da = (from x in db.DoAns where x.idGiangVien.Equals(idgiangvien) select x).SingleOrDefault();
            doan.idDoAn = doan.idDoAn;
            doan.tenDoAn = doan.tenDoAn;
            doan.noiDung = doan.noiDung;
            doan.khoaHoc = doan.khoaHoc;
            doan.khoa = doan.khoa;
            doan.idGiangVien = doan.idGiangVien;
            return doan;

        }

        public bool deleteDoAn(int madoan)
        {
            DoAn dtemp = db.DoAns.Where(x => x.idDoAn == madoan).FirstOrDefault();
            if (dtemp != null)
            {
                db.DoAns.Remove(dtemp);
                db.SaveChanges(); //cập nhật việc xóa vào CSDL
                return true; //xóa thành công
            }
            return false;
        }
        public int updateDoAn(DoAn doanupdate)
        {
            IQueryable<DoAn> d = db.DoAns.Where(x => x.idDoAn.Equals(doanupdate.idDoAn));
            d.First().idDoAn = doanupdate.idDoAn;
            d.First().tenDoAn = doanupdate.tenDoAn;
            d.First().noiDung =doanupdate.noiDung;
            d.First().khoaHoc =doanupdate.khoaHoc;
            d.First().khoa =doanupdate.khoa;
            d.First().idGiangVien =doanupdate.idGiangVien;

            db.SaveChanges();
            return 1;
        }

        public int insertDoAn(DoAn doannew)
        {
            DoAn dtemp = new DoAn();
            dtemp.tenDoAn = "";
            dtemp.noiDung = doannew.noiDung;
            dtemp.khoaHoc = doannew.khoaHoc;
            dtemp.khoa = doannew.khoa;
            dtemp.idGiangVien = dtemp.idGiangVien;
            
            db.DoAns.Add(dtemp);
            db.SaveChanges();
            return 1;
        }
    }
}

using Model.Entities;
using Repository;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SinhVienService : ISinhVienService
    {
        private IDangKyDoAnRepository<SinhVien> sinhVienRepository;

        public SinhVienService()
        {
            sinhVienRepository = new DangKyDoAnRepository<SinhVien>();
        }

        public SinhVien Add(SinhVien entity)
        {
            return sinhVienRepository.Add(entity);
        }

        public bool Delete(int id)
        {
            var existing = GetById(id);
            if(existing != null)
                return sinhVienRepository.Delete(id);
            return false;
        }

        public IEnumerable<SinhVien> GetAll()
        {
            return sinhVienRepository.GetByWhere(x => true);
        }

        public SinhVien GetById(int id)
        {
            return sinhVienRepository.GetByCondition(x => x.idSinhVien.Equals(id));
        }

        public string GetName(int id)
        {
            return sinhVienRepository.GetByCondition(x => x.idSinhVien.Equals(id)).hoTen;
        }

        public SinhVien Login(int idSinhVien, string password)
        {
            return sinhVienRepository.GetByCondition(x => x.idSinhVien.Equals(idSinhVien) && x.password.Equals(password));
        }

        public SinhVien Update(SinhVien entity)
        {
            var existing = GetById(entity.idSinhVien);
            if(existing != null)
            {
                existing.diaChi = entity.diaChi;
                existing.email = entity.email;
                existing.hoTen = entity.hoTen;
                existing.khoa = entity.hoTen;
                existing.nienKhoa = entity.nienKhoa;
                existing.soDienThoai = entity.soDienThoai;
                existing.idDoAn = entity.idDoAn;
                return sinhVienRepository.Update(existing);
            }
            return null;
        }
        
        public SinhVien HuyDoAn(int id)
        {
            var existing = GetById(id);
            if(existing != null)
            {
                existing.idDoAn = null;
                return sinhVienRepository.Update(existing);
            }
            return null;
        }
        public SinhVien DangKyDoAn(int idSinhVien, int idDoAn)
        {
            var existing = GetById(idSinhVien);
            if(existing != null)
            {
                existing.idDoAn = idDoAn;
                return sinhVienRepository.Update(existing);
            }
            return null;
        }
    }
}

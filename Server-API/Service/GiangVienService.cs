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
    public class GiangVienService : IGiangVienService
    {
        private IDangKyDoAnRepository<GiangVien> giangVienRepository;

        public GiangVienService()
        {
            giangVienRepository = new DangKyDoAnRepository<GiangVien>();
        }

        public GiangVien Add(GiangVien entity)
        {
            return giangVienRepository.Add(entity);
        }

        public bool Delete(int id)
        {
            var existing = GetById(id);
            if(existing != null)
                return giangVienRepository.Delete(id);
            return false;
        }

        public IEnumerable<GiangVien> GetAll()
        {
            return giangVienRepository.GetByWhere(x => true);
        }

        public GiangVien GetById(int id)
        {
            return giangVienRepository.GetByCondition(x => x.idGiangVien.Equals(id));
        }

        public string GetName(int id)
        {
            return giangVienRepository.GetByCondition(x => x.idGiangVien.Equals(id)).hoTen;
        }

        public GiangVien Login(int idGiangVien, string password)
        {
            return giangVienRepository.GetByCondition(x => x.idGiangVien.Equals(idGiangVien) && x.password.Equals(password));
        }

        public GiangVien Update(GiangVien entity)
        {
            var existing = GetById(entity.idGiangVien);
            if(existing != null)
            {
                existing.chucVu = entity.chucVu;
                existing.diaChi = entity.diaChi;
                existing.email = entity.email;
                existing.hoTen = entity.hoTen;
                existing.khoa = entity.khoa;
                existing.soDienThoai = entity.soDienThoai;
                return giangVienRepository.Update(entity);
            }
            return null;
        }
    }
}

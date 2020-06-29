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
    public class AdminService : IAdminService
    {
        private IDangKyDoAnRepository<Admin> adminRepository;

        public AdminService()
        {
            adminRepository = new DangKyDoAnRepository<Admin>();
        }

        public Admin Add(Admin entity)
        {
            return adminRepository.Add(entity);
        }

        public bool Delete(int id)
        {
            var existing = GetById(id);
            if(existing != null)
                return adminRepository.Delete(id);
            return false;
        }

        public IEnumerable<Admin> GetAll()
        {
            return adminRepository.GetByWhere(x => true);
        }

        public Admin GetById(int id)
        {
            return adminRepository.GetByCondition(x => x.idAdmin.Equals(id));
        }

        public int GetID(string hoTen)
        {
            return adminRepository.GetByCondition(x => x.hoTen.Equals(hoTen)).idAdmin;
        }

        public string GetName(int id)
        {
            return adminRepository.GetByCondition(x => x.idAdmin.Equals(id)).hoTen;
        }

        public Admin Update(Admin entity)
        {
            var existing = GetById(entity.idAdmin);
            if(existing != null)
            {
                existing.chucVu = entity.chucVu;
                existing.email = entity.email;
                existing.hoTen = entity.hoTen;
                existing.khoa = entity.khoa;
                existing.soDienThoai = entity.soDienThoai;
                return adminRepository.Update(entity);
            }
            return null;
        }
    }
}


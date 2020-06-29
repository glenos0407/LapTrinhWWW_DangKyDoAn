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
    public class DoAnService : IDoAnService
    {
        private IDangKyDoAnRepository<DoAn> doAnRepository;

        public DoAnService()
        {
            doAnRepository = new DangKyDoAnRepository<DoAn>();
        }

        public DoAn Add(DoAn entity)
        {
            return doAnRepository.Add(entity);
        }

        public bool Delete(int id)
        {
            var existing = GetById(id);
            if(existing != null)
                return doAnRepository.Delete(id);
            return false;
        }

        public IEnumerable<DoAn> GetAll()
        {
            return doAnRepository.GetByWhere(x => true);
        }

        public DoAn GetById(int id)
        {
            return doAnRepository.GetByCondition(x => x.idDoAn.Equals(id));
        }

        public DoAn GetDoAnByIDGiangVien(int idgiangvien)
        {
            return doAnRepository.GetByCondition(x => x.idGiangVien.Equals(idgiangvien));
        }

        public int GetID(string tendoan)
        {
            return doAnRepository.GetByCondition(x => x.tenDoAn.Equals(tendoan)).idDoAn;
        }

        public string GetName(int id)
        {
            return doAnRepository.GetByCondition(x => x.idDoAn.Equals(id)).tenDoAn;
        }

        public DoAn Update(DoAn entity)
        {
            var existing = GetById(entity.idDoAn);
            if(existing != null)
            {
                existing.khoa = entity.khoa;
                existing.khoaHoc = entity.khoaHoc;
                existing.noiDung = entity.noiDung;
                existing.tenDoAn = entity.tenDoAn;
                return doAnRepository.Update(entity);
            }
            return null;
        }
    }
}

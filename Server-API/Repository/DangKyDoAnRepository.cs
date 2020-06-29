using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model.DataContext;

namespace Repository
{
    public class DangKyDoAnRepository<TEntity> : IDangKyDoAnRepository<TEntity> where TEntity : class
    {
        private DangKyDoAn_DBContext db;

        public DangKyDoAnRepository()
        {
            db = new DangKyDoAn_DBContext();
        }

        public TEntity Add(TEntity entity)
        {
            var result = db.Set<TEntity>().Add(entity);
            db.SaveChanges();
            return result;
        }

        public bool Delete(object id)
        {
            var entityExisted = db.Set<TEntity>().Find(id);
            if(entityExisted != null)
            {
                db.Set<TEntity>().Remove(entityExisted);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>();
        }

        public TEntity GetByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return db.Set<TEntity>().FirstOrDefault(expression);
        }

        public IEnumerable<TEntity> GetByWhere(Expression<Func<TEntity, bool>> expression)
        {
            return db.Set<TEntity>().Where(expression);
        }

        public TEntity Update(TEntity entity)
        {
            var result =  db.Set<TEntity>().Attach(entity);
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return result;
        }
    }
}

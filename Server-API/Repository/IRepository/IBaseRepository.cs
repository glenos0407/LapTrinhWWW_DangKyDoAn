using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBaseRepository<TEntity>
    {
        TEntity GetByCondition(Expression<Func<TEntity, bool>> expression);
        IEnumerable<TEntity> GetByWhere(Expression<Func<TEntity, bool>> expression);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        bool Delete(object id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        bool Delete(int id);
        IEnumerable<TEntity> GetAll();
        string GetName(int id);
    }
}

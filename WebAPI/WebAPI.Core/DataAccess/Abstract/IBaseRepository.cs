using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Core.DataAccess.Abstract
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(int id);

    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace WebAPI.Business.Abstract
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);

    }
}

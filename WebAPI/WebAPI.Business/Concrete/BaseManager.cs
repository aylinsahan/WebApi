using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebAPI.Business.Abstract;
using WebAPI.Core.DataAccess.Abstract;

namespace WebAPI.Business.Concrete
{
    public class BaseManager<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private IBaseRepository<TEntity> _baseRepository;
        public BaseManager(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public TEntity Add(TEntity entity)
        {
            return _baseRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _baseRepository.Get(filter);
        }

        public IList<TEntity> GetAll()
        {
            return _baseRepository.GetAll();
        }

 
        public void Update(TEntity entity)
        {
            _baseRepository.Update(entity);
        }
    }
}


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.DataAccess.Abstract;

namespace WebAPI.Core.DataAccess.Concrete
{
    public abstract class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
         where TEntity : class, new()
         where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }

        }

        public void Delete(int id)
        {
            using (var context = new TContext())
            {
                var data = context.Set<TEntity>().Find(id);
                var deleteEntity = context.Entry(data);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public IList<TEntity> GetAll()
        {
            using (var context = new TContext())
            {

                return context.Set<TEntity>().ToList();

            }
        }

       public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }


    }
}

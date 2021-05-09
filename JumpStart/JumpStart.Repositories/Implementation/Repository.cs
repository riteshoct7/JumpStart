using JumpStart.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace JumpStart.Repositories.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        #region Properties

        protected readonly DbContext context;

        #endregion

        #region Constructors

        public Repository(DbContext context)
        {
            this.context = context;
        }

        #endregion

        #region Methods

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public void Delete(object id)
        {
            var entity = context.Set<TEntity>().Find(id);
            if (entity != null)
            {
                context.Set<TEntity>().Remove(entity);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetById(object id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public void Save(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
        } 

        #endregion

    }
}

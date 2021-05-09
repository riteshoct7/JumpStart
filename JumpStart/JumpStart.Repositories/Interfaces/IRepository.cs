using System.Collections.Generic;

namespace JumpStart.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity:class
    {

        #region Methods

        TEntity GetById(object id);

        IEnumerable<TEntity> GetAll();

        void Save(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Delete(object id);

        void Remove(TEntity entity);

        int SaveChanges(); 

        #endregion

    }
}

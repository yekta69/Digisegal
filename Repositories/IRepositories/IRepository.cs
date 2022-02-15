using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Digisegal.Repositories.IRepositories
{
   public interface IRepository<TEntity> where  TEntity :class
   {
        //Get
        Task<IEnumerable<TEntity>> GetAllAsync();
        IEnumerable<TEntity> GetAll();
        Task<TEntity> GetAsync(object id);
        TEntity Get(object id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);


        //Add
        Task Add(TEntity entity);
        Task AddRange(IEnumerable<TEntity> entities);

        IQueryable<TEntity> entity();

        //Remove
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);


        //Update
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
    

   }
}

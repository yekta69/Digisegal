using Digisegal.Models.Segal_DbContext;
using Digisegal.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Digisegal.Repositories
{
    public class Repository <TEntity> : IRepository <TEntity>
        where TEntity :class
    {

        
        protected readonly StoreSegalDbContext context;
        protected readonly DbSet<TEntity> dbset;
        public Repository(StoreSegalDbContext context)
        {

            this.context = context;
            dbset = context.Set<TEntity>();
        }
        public async virtual Task Add(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
        }

        public async virtual Task AddRange(IEnumerable<TEntity> entities)
        {
            await context.Set<TEntity>().AddRangeAsync(entities);
        }

        public IQueryable<TEntity> entity() => context.Set<TEntity>();

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(object id)
        {

            return
               context.Set<TEntity>().Find(id);

        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }


        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().ToListAsync();
        }


        public async Task<TEntity> GetAsync(object id)
        {

            return await context.Set<TEntity>().FindAsync(id);


        }

        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);

        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().AttachRange(entities);
            context.Entry(entities).State = EntityState.Modified;
        }

    }
}

  

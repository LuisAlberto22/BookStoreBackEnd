using BookStore.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookStore.Repositories.Interfaces
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseModel
    {
        protected readonly DbContext context;
        protected readonly DbSet<TEntity> DBSet;

        public RepositoryBase(DbContext context)
        {
            this.context = context;
            DBSet = context.Set<TEntity>();
        }
        public virtual async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await DBSet
                .AsNoTracking()
                .ToListAsync();
        }
        public virtual async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DBSet
                .Where(predicate)
                .AsNoTracking()
                .ToListAsync();
        }
        public virtual async Task<ICollection<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy)
        {
            return await DBSet
                .Where(predicate)
                .OrderBy(orderBy)
                .AsNoTracking()
                .ToListAsync();
        }
        public virtual async Task<TEntity?> FindAsync(int id)
        {
            return await DBSet.FindAsync(id);
        }
        public virtual async Task AddAsync(TEntity entity)
        {
            await DBSet.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await DBSet.AddRangeAsync(entities);
        }

        public virtual async Task UpdateAsync()
        {
            await context.SaveChangesAsync();
        }
        public virtual async Task DeleteAsync(int id)
        {
            var entity = await FindAsync(id);

            if (entity is not null)
            {
                DBSet.Remove(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}

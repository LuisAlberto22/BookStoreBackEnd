using BookStore.Entities.Interfaces;
using System.Linq.Expressions;

namespace BookStore.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseModel
    {
        Task AddAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task<ICollection<TEntity>> GetAllAsync();
        Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task<TEntity?> FindAsync(int id);
        Task<ICollection<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy);
        Task UpdateAsync();
    }
}
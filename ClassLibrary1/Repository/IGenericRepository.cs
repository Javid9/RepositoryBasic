    using ClassLibrary1.Entity;
using System.Linq.Expressions;

namespace ClassLibrary1.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        Task<IList<TEntity>> GetAllAsync();
        Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> Get(string id);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);

        Task CreateAsync(TEntity entity); 
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(string id);    
    }
}

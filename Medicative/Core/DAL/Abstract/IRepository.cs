using Core.Entity.Abstract;
using System.Linq.Expressions;

namespace Core.DAL.Abstract
{
    public interface IRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params Expression<Func<TEntity, object>>[] includes);
        Task<List<TEntity>> GetAllPaginatedAsync(int activePage, int size, Expression<Func<TEntity, bool>> expression = null, params Expression<Func<TEntity, object>>[] includes);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes);
        Task<bool> IsExist(Expression<Func<TEntity, bool>> expression);
        Task CreateAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> expression);
    }
}

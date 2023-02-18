using Core.DAL.Abstract;
using Core.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DAL.Concrete.EntityFramework
{
    public class EFBaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
    {

        private readonly DbContext _context;
        public EFBaseRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().CountAsync(expression);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (includes.Any())
            {
                foreach (var exp in includes)
                {
                    query = query.Include(exp);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<List<TEntity>> GetAllPaginatedAsync(int activePage, int size, Expression<Func<TEntity, bool>> expression = null, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            if (expression != null)
            {
                query = query.Where(expression);
            }

            query = query.Skip((activePage - 1) * size).Take(size);

            if (includes.Any())
            {
                foreach (var exp in includes)
                {
                    query = query.Include(exp);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().Where(expression);

            if (includes.Any())
            {
                foreach (var exp in includes)
                {
                    query = query.Include(exp);
                }
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task<bool> IsExist(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().AnyAsync(expression);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}

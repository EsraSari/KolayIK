using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KolayIK.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ValueTask<TEntity> GetByIDAsync(int id);    

        Task<IEnumerable<TEntity>> GetAllAsync(); 

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter);
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filter);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> filter);

        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}

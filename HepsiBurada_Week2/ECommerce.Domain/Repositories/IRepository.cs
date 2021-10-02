using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity entity);

        Task Delete(TEntity entity);

        Task Update(TEntity entity);

        Task<List<TEntity>> Get(Expression<Func<TEntity, bool>> filter);

        Task<List<TEntity>> GetAll();

        Task<TEntity> GetByIdAsync(int id);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

    }
}

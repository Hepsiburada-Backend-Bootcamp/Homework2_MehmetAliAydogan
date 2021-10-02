using ECommerce.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class

    {
        private readonly ECommerceDbContext _dbContext;
        DbSet<TEntity> _dbSet;

        public Repository(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public async Task Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task Delete(TEntity entity)
        {
            _dbSet.Remove(entity);

            await _dbContext.SaveChangesAsync();
        }

        public Task<List<TEntity>> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter).ToListAsync();
        }

        public Task<List<TEntity>> GetAll()
        {
            return _dbSet.ToListAsync();
        }

        public async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<TEntity> SingleOrDefaultAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.SingleOrDefaultAsync(predicate);
        }
    }
}

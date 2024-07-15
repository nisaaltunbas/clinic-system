using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Models
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DbContext _context;
        protected DbSet<T> _set;

        protected GenericRepository(DbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>>? predicate = null)
        {
            return predicate != null ? await _set.AnyAsync(predicate) : await _set.AnyAsync();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            return predicate != null ? await _set.CountAsync(predicate) : await _set.CountAsync();
        }

        public async Task CreateManyAsync(IEnumerable<T> entities) => await _set.AddRangeAsync(entities);

        public async Task CreateOneAsync(T entity) => await _set.AddAsync(entity);

        public async Task DeleteManyAsync(IEnumerable<T> entities)
        {
            await Task.Run(() => _set.RemoveRange(entities));
        }

        public async Task DeleteManyAsync(Expression<Func<T, bool>>? predicate = null)
        {
            var entities = await ReadManyAsync(predicate);
            await DeleteManyAsync(entities);
        }

        public async Task DeleteOneAsync(object entityKey)
        {
            var entity = await ReadOneAsync(entityKey);
            if (entity != null)
            {
                await DeleteOneAsync(entity);
            }
        }

        public async Task DeleteOneAsync(T entity)
        {
            await Task.Run(() => _set.Remove(entity));
        }

        public async Task<T?> ReadFirstAsync(Expression<Func<T, bool>>? predicate = null)
        {
            return predicate != null ? await _set.FirstOrDefaultAsync(predicate) : await _set.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> ReadManyAsync(Expression<Func<T, bool>>? predicate = null, string[]? includes = null)
        {
            IQueryable<T> entities = predicate != null ? _set.Where(predicate) : _set;
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }
            return await entities.ToListAsync();
        }

        public async Task<T?> ReadOneAsync(object entityKey) => await _set.FindAsync(entityKey);

        public async Task UpdateManyAsync(IEnumerable<T> entities)
        {
            await Task.Run(() => _set.UpdateRange(entities));
        }

        public async Task UpdateOneAsync(T entity)
        {
            await Task.Run(() => _set.Update(entity));
        }
    }
}

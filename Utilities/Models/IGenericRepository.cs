using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Models
{
    public interface IGenericRepository<T> where T : class
    {
        Task CreateOneAsync(T entity);
        Task CreateManyAsync(IEnumerable<T> entities);

        Task<T?> ReadOneAsync(object entityKey);
        Task<T?> ReadFirstAsync(Expression<Func<T, bool>>? predicate = null);
        Task<IEnumerable<T>> ReadManyAsync(Expression<Func<T, bool>>? predicate = null, string[]? includes = null);

        Task UpdateOneAsync(T entity);
        Task UpdateManyAsync(IEnumerable<T> entities);

        Task DeleteOneAsync(object entityKey);
        Task DeleteOneAsync(T entity);
        Task DeleteManyAsync(IEnumerable<T> entities);
        Task DeleteManyAsync(Expression<Func<T, bool>>? predicate = null);

        Task<bool> AnyAsync(Expression<Func<T, bool>>? predicate = null);
        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Repositories.Repository
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        Task RemoveById(string id);
        Task RemoveByIntId(int id);
        void RemoveAll();

    }
}

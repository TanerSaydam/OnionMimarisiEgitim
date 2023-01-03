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
        void Update(T entity);
        void Remove(T entity);
        Task RemoveById(string id);

    }
}

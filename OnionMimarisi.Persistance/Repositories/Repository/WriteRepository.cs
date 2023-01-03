using Microsoft.EntityFrameworkCore;
using OnionMimarisi.Application.Repositories.Repository;
using OnionMimarisi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance.Repositories.Repository
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public WriteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Entity => _context.Set<T>();

        public async Task CreateAsync(T entity)
        {
            await Entity.AddAsync(entity);
        }

        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveById(string id)
        {
            T entity = await Entity.FindAsync(Guid.Parse(id));
            Remove(entity);
        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }
    }
}

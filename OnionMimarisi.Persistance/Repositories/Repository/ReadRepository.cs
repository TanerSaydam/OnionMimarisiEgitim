using Microsoft.EntityFrameworkCore;
using OnionMimarisi.Application.Repositories.Repository;
using OnionMimarisi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance.Repositories.Repository
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public ReadRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Entity => _context.Set<T>();

        public async Task<T> FirstAsync(Expression<Func<T, bool>> expression)
        {
            T entity = await Entity.Where(expression).FirstOrDefaultAsync();
            return entity;
        }

        public IQueryable<T> GetAll()
        {
            return Entity.AsQueryable();
        }

        public async Task<T> GetFirst()
        {
            return await Entity.FirstOrDefaultAsync();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Entity.Where(expression).AsQueryable();
        }
    }
}

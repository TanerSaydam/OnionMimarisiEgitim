using OnionMimarisi.Application.Repositories.CategoryRepository;
using OnionMimarisi.Domain.Entities;
using OnionMimarisi.Persistance.Context;
using OnionMimarisi.Persistance.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance.Repositories.CategoryRepository
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepostory
    {
        public CategoryReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

using OnionMimarisi.Application.Repositories.ProductRespository;
using OnionMimarisi.Domain.Entities;
using OnionMimarisi.Persistance.Context;
using OnionMimarisi.Persistance.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance.Repositories.ProductRepository
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

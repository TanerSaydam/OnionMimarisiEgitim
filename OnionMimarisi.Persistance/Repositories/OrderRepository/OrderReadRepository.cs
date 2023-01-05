using OnionMimarisi.Application.Repositories.OrderRepository;
using OnionMimarisi.Application.Repositories.Repository;
using OnionMimarisi.Domain.Entities;
using OnionMimarisi.Persistance.Context;
using OnionMimarisi.Persistance.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance.Repositories.OrderRepository
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

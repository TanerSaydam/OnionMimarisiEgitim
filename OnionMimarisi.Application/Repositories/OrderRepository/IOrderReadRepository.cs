using OnionMimarisi.Application.Repositories.Repository;
using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Repositories.OrderRepository
{
    public interface IOrderReadRepository: IReadRepository<Order>
    {
    }
}

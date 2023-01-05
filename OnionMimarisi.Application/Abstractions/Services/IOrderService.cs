using OnionMimarisi.Domain.Dtos;
using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Abstractions.Services
{
    public interface IOrderService
    {
        Task CustomerAndOrderListCreateAsync(IEnumerable<Customer> customers, IEnumerable<Order> orders);
        IQueryable<Order> GetAllOrders();
        IList<OrderDto> GetAllOrdersWithCustomers();
        Task RemoveById(int id);

        Task<Order> GetById(int id);
        Task UpdateAsync(Order order);
    }
}

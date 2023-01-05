using Microsoft.EntityFrameworkCore;
using OnionMimarisi.Application.Abstractions.Services;
using OnionMimarisi.Application.Repositories.OrderRepository;
using OnionMimarisi.Application.Repositories.Repository;
using OnionMimarisi.Domain.Dtos;
using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly ICustomerService _customerService;        
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderWriteRepository orderWriteRepository, IUnitOfWork unitOfWork, ICustomerService customerService, IOrderReadRepository orderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _unitOfWork = unitOfWork;
            _customerService = customerService;
            _orderReadRepository = orderReadRepository;
        }

        public async Task CustomerAndOrderListCreateAsync(IEnumerable<Customer> customers, IEnumerable<Order> orders)
        {
            _orderWriteRepository.RemoveAll();
            _customerService.RemoveAll();


            await _orderWriteRepository.AddRangeAsync(orders);
            await _customerService.CreateXmlRangeAsync(customers);
            await _unitOfWork.SaveChangesAsync();
        }

        public IQueryable<Order> GetAllOrders()
        {
            var result = _orderReadRepository.GetAll().Include("ShipInfo");
            return result;
        }

        public IList<OrderDto> GetAllOrdersWithCustomers()
        {
            var result = _orderReadRepository.GetAll().Include("ShipInfo").Select(s=> new OrderDto
            {
                CustomerID = s.CustomerID,
                EmployeeID = s.EmployeeID,
                Id = s.Id,
                OrderDate = s.OrderDate,
                RequiredDate = s.RequiredDate,
                ShipInfo = s.ShipInfo,
                CustomerName = _customerService.GetCustomerNameByCustomerID(s.CustomerID) 
            });

            return result.ToList();
        }

        public async Task<Order> GetById(int id)
        {
            var result = await _orderReadRepository.GetWhere(p=> p.Id == id).Include("ShipInfo").FirstOrDefaultAsync();
            return result;
        }

        public async Task RemoveById(int id)
        {
            await _orderWriteRepository.RemoveByIntId(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Order order)
        {
           _orderWriteRepository.Update(order);
            await _unitOfWork.SaveChangesAsync();            
        }
    }
}

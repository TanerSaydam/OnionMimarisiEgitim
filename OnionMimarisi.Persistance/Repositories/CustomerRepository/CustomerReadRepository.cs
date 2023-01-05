using OnionMimarisi.Application.Repositories.CustomerRepository;
using OnionMimarisi.Application.Repositories.Repository;
using OnionMimarisi.Domain.Dtos;
using OnionMimarisi.Domain.Entities;
using OnionMimarisi.Persistance.Context;
using OnionMimarisi.Persistance.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance.Repositories.CustomerRepository
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        private ApplicationDbContext _context;
        public CustomerReadRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public CustomerWithOrderListDto GetCustomerWithOrderList(string customerID)
        {
            var result = _context.Customers.AsQueryable().FirstOrDefault();
            CustomerWithOrderListDto customerWithOrderListDto = new CustomerWithOrderListDto
            {
                CompanyName = result.CompanyName,
                ContactName = result.ContactName,
                ContactTitle = result.ContactTitle,
                CustomerID = customerID,
                FullAddress = result.FullAddress,
                Id = result.Id,
                Phone = result.Phone,
                Orders = _context.Orders.Where(p => p.CustomerID == customerID).ToList(),
            };

            return customerWithOrderListDto;
        }
    }
}

using OnionMimarisi.Application.Abstractions.Services;
using OnionMimarisi.Application.Repositories.CustomerRepository;
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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerWriteRepository _customerWriteRepository;
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(ICustomerWriteRepository customerWriteRepository, IUnitOfWork unitOfWork, ICustomerReadRepository customerReadRepository)
        {
            _customerWriteRepository = customerWriteRepository;
            _unitOfWork = unitOfWork;
            _customerReadRepository = customerReadRepository;
        }

        public async Task CreateXmlRangeAsync(IEnumerable<Customer> customers)
        {            
            await _customerWriteRepository.AddRangeAsync(customers);            
        }

        public string GetCustomerNameByCustomerID(string customerID)
        {
            string name = _customerReadRepository.GetWhere(p => p.CustomerID == customerID).FirstOrDefault().CompanyName;
            return name;
        }

        public CustomerWithOrderListDto GetCustomerWithOrderList(string customerID)
        {
            return _customerReadRepository.GetCustomerWithOrderList(customerID);
        }

        public void RemoveAll()
        {
            _customerWriteRepository.RemoveAll();
        }
    }
}

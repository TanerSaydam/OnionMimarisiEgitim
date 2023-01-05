using OnionMimarisi.Application.Abstractions.Services;
using OnionMimarisi.Application.Repositories.CustomerRepository;
using OnionMimarisi.Application.Repositories.Repository;
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
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(ICustomerWriteRepository customerWriteRepository, IUnitOfWork unitOfWork)
        {
            _customerWriteRepository = customerWriteRepository;
            _unitOfWork = unitOfWork;            
        }

        public async Task CreateXmlRangeAsync(IEnumerable<Customer> customers)
        {            
            await _customerWriteRepository.AddRangeAsync(customers);            
        }

        public void RemoveAll()
        {
            _customerWriteRepository.RemoveAll();
        }
    }
}

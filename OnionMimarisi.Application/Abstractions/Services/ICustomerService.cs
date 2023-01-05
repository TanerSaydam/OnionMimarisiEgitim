using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Abstractions.Services
{
    public interface ICustomerService
    {
        void RemoveAll();
        Task CreateXmlRangeAsync(IEnumerable<Customer> customers);
        
    }
}

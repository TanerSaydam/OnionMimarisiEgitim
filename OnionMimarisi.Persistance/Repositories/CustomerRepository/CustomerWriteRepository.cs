using OnionMimarisi.Application.Repositories.CustomerRepository;
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
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

using OnionMimarisi.Application.Features.Commands.ProductFeature.CreateProduct;
using OnionMimarisi.Application.Repositories.Repository;
using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Repositories.ProductRespository
{
    public interface IProductWriteRepository : IWriteRepository<Product>
    {
    }
}

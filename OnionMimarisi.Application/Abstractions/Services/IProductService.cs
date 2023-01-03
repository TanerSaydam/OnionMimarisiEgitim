using OnionMimarisi.Application.Features.Commands.ProductFeature.CreateProduct;
using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Abstractions.Services
{
    public interface IProductService
    {
        Task CreateProduct(CreateProductCommandRequest request);
        IQueryable<Product> GetAll();
    }
}

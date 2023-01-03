using Microsoft.EntityFrameworkCore;
using OnionMimarisi.Application.Abstractions.Services;
using OnionMimarisi.Application.Features.Commands.ProductFeature.CreateProduct;
using OnionMimarisi.Application.Repositories.ProductRespository;
using OnionMimarisi.Application.Repositories.Repository;
using OnionMimarisi.Domain.Entities;
using OnionMimarisi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductWriteRepository productWriteRepository, IUnitOfWork unitOfWork, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _unitOfWork = unitOfWork;
            _productReadRepository = productReadRepository;
        }

        public async Task CreateProduct(CreateProductCommandRequest request)
        {
            Product product = new();
            product.Id = Guid.NewGuid();
            product.Name = request.Name;
            product.CategoryId = Guid.Parse(request.CategoryId);

            await _productWriteRepository.CreateAsync(product);


            //kayıtlar
            //kayıtlar


            await _unitOfWork.SaveChangesAsync();
        }

        public IQueryable<Product> GetAll()
        {
            return _productReadRepository.GetAll().Include("Category");
        }
    }
}

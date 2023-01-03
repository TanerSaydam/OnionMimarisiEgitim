using Microsoft.Extensions.DependencyInjection;
using OnionMimarisi.Application.Abstractions.Services;
using OnionMimarisi.Application.Repositories.CategoryRepository;
using OnionMimarisi.Application.Repositories.ProductRespository;
using OnionMimarisi.Application.Repositories.Repository;
using OnionMimarisi.Persistance.Repositories.CategoryRepository;
using OnionMimarisi.Persistance.Repositories.ProductRepository;
using OnionMimarisi.Persistance.Repositories.Repository;
using OnionMimarisi.Persistance.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistanceService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<ICategoryReadRepostory, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}

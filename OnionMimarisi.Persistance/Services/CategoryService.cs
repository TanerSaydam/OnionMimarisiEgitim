using OnionMimarisi.Application.Abstractions.Services;
using OnionMimarisi.Application.Features.Commands.CategoryFeature.CreateCategory;
using OnionMimarisi.Application.Repositories.CategoryRepository;
using OnionMimarisi.Application.Repositories.Repository;
using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Persistance.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly ICategoryReadRepostory _categoryReadRepostory;
               

        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryWriteRepository categoryWriteRepository, IUnitOfWork unitOfWork, ICategoryReadRepostory categoryReadRepostory)
        {
            _categoryWriteRepository = categoryWriteRepository;
            _unitOfWork = unitOfWork;
            _categoryReadRepostory = categoryReadRepostory;
        }

        public async Task<Category> CheckCategoryName(string name)
        {
            return await _categoryReadRepostory.FirstAsync(p => p.Name == name);
        }

        public async Task CreateCategory(CreateCategoryCommandRequest request)
        {
            Category category = new();
            category.Name = request.Name;
            category.Id = Guid.NewGuid();

            await _categoryWriteRepository.CreateAsync(category);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}

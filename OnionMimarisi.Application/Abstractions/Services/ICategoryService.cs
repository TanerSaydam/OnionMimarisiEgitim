using OnionMimarisi.Application.Features.Commands.CategoryFeature.CreateCategory;
using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Abstractions.Services
{
    public interface ICategoryService
    {
        Task CreateCategory(CreateCategoryCommandRequest request);
        Task<Category> CheckCategoryName(string name);
    }
}

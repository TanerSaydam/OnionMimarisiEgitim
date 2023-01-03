using MediatR;
using OnionMimarisi.Application.Abstractions.Services;
using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Commands.CategoryFeature.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        private readonly ICategoryService _categoryService;

        public CreateCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            Category checkCategory = await _categoryService.CheckCategoryName(request.Name);
            if (checkCategory == null) {
                await _categoryService.CreateCategory(request);
            }
            else
            {
                throw new Exception("Bu kategory adı kullanılmış!");
            }

            
            return new();
        }
    }
}

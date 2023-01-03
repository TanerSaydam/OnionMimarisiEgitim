using MediatR;

namespace OnionMimarisi.Application.Features.Commands.CategoryFeature.CreateCategory
{
    public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
    }
}

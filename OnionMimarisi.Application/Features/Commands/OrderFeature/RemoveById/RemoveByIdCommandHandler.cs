using MediatR;
using OnionMimarisi.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Commands.OrderFeature.RemoveById
{
    public class RemoveByIdCommandHandler : IRequestHandler<RemoveByIdCommandRequest, RemoveByIdCommandResponse>
    {
        private readonly IOrderService _orderService;

        public RemoveByIdCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<RemoveByIdCommandResponse> Handle(RemoveByIdCommandRequest request, CancellationToken cancellationToken)
        {
            await _orderService.RemoveById(request.Id);
            return new();
        }
    }
}

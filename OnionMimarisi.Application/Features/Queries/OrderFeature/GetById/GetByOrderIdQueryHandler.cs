using MediatR;
using OnionMimarisi.Application.Abstractions.Services;
using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Queries.OrderFeature.GetById
{
    public class GetByOrderIdQueryHandler : IRequestHandler<GetByOrderIdQueryRequest, GetByOrderIdQueryResponse>
    {
        private readonly IOrderService _orderService;

        public GetByOrderIdQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetByOrderIdQueryResponse> Handle(GetByOrderIdQueryRequest request, CancellationToken cancellationToken)
        {
            Order order = await _orderService.GetById(request.Id);
            return new GetByOrderIdQueryResponse { Order= order };
        }
    }
}

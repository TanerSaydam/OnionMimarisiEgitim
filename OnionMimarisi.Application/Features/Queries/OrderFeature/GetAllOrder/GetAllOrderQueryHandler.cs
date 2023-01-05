using MediatR;
using OnionMimarisi.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Queries.OrderFeature.GetAllOrder
{
    public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQueryRequest, GetAllOrderQueryResponse>
    {
        private readonly IOrderService _orderService;

        public GetAllOrderQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetAllOrderQueryResponse> Handle(GetAllOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var result = _orderService.GetAllOrders();
            return new GetAllOrderQueryResponse { Orders = result };
        }
    }
}

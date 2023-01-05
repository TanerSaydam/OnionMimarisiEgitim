using MediatR;
using OnionMimarisi.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Queries.CustomerFeature.GetCustomerWithOrderList
{
    public class GetCustomerWithOrderListQueryHandler : IRequestHandler<GetCustomerWithOrderListQueryRequest, GetCustomerWithOrderListQueryResponse>
    {
        private readonly ICustomerService _customerService;

        public GetCustomerWithOrderListQueryHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<GetCustomerWithOrderListQueryResponse> Handle(GetCustomerWithOrderListQueryRequest request, CancellationToken cancellationToken)
        {
            var result = _customerService.GetCustomerWithOrderList(request.CustomerId);
            return new GetCustomerWithOrderListQueryResponse { CustomerWithOrderListDtos= result };
        }
    }
}

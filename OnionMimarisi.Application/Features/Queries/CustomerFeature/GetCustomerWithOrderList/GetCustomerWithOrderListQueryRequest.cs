using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Queries.CustomerFeature.GetCustomerWithOrderList
{
    public class GetCustomerWithOrderListQueryRequest : IRequest<GetCustomerWithOrderListQueryResponse>
    {
        public string CustomerId { get; set; }
    }
}

using OnionMimarisi.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Queries.CustomerFeature.GetCustomerWithOrderList
{
    public class GetCustomerWithOrderListQueryResponse
    {
        public CustomerWithOrderListDto CustomerWithOrderListDtos { get; set; }
    }
}

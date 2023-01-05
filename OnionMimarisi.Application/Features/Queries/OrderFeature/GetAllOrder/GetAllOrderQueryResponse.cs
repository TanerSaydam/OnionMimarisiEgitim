using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Queries.OrderFeature.GetAllOrder
{
    public class GetAllOrderQueryResponse
    {
        public IQueryable<Order> Orders { get; set; }
    }
}

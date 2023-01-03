using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Queries.ProductFeature.GetAllProduct
{
    public class GetAllProductQueryResponse
    {
        public IQueryable<Product> Products { get; set; }
    }
}

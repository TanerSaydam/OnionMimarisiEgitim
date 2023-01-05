using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Queries.OrderFeature.GetById
{
    public class GetByOrderIdQueryRequest : IRequest<GetByOrderIdQueryResponse>
    {
        public int Id { get; set; }
    }
}

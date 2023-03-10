using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Commands.OrderFeature.RemoveById
{
    public class RemoveByIdCommandRequest : IRequest<RemoveByIdCommandResponse>
    {
        public int Id { get; set; }
    }
}

using MediatR;
using OnionMimarisi.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Commands.OrderFeature.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;

        public UpdateOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var order = await _orderService.GetById(request.Id);

            order.CustomerID= request.CustomerID;
            order.EmployeeID = request.EmployeeID;
            order.RequiredDate= request.RequiredDate;
            order.OrderDate= request.OrderDate;
            order.ShipInfo.ShipName = request.ShipName;
            await _orderService.UpdateAsync(order);

            return new();
        }
    }
}

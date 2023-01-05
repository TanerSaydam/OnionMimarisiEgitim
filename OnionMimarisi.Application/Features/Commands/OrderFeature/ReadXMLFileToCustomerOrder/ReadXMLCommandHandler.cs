using MediatR;
using OnionMimarisi.Application.Abstractions.Services;
using OnionMimarisi.Domain.Dtos;
using OnionMimarisi.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Commands.OrderFeature.ReadXMLFileToCustomerOrder
{
    public class ReadXMLCommandHandler : IRequestHandler<ReadXMLCommandRequest, ReadXMLCommandResponse>
    {
        private readonly IOrderService _orderService;

        public ReadXMLCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<ReadXMLCommandResponse> Handle(ReadXMLCommandRequest request, CancellationToken cancellationToken)
        {
            string fileName = FileManager<object>.FileSaveToServer(request.File, "./wwwroot/files/");
            string path = $"./wwwroot/files/{fileName}";
            RootDto rootDto = FileManager<RootDto>.ConvertXMLToObject(path);
           
            await _orderService.CustomerAndOrderListCreateAsync(rootDto.Customers.Customer, rootDto.Orders.Order);

            FileManager<object>.RemoveFileToServer(path);

            return new();
        }
    }
}

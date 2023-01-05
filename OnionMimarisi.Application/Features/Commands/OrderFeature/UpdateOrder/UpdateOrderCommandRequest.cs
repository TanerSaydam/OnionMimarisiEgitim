using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Commands.OrderFeature.UpdateOrder
{
    public class UpdateOrderCommandRequest : IRequest<UpdateOrderCommandResponse>
    {
        public int Id { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string ShipName { get; set; }
     
    }
}

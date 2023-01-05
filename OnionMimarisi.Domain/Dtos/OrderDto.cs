using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnionMimarisi.Domain.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }        
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }        
        public int EmployeeID { get; set; }        
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public ShipInfo ShipInfo { get; set; }
    }
}

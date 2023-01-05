using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnionMimarisi.Domain.Dtos
{
    public class CustomerWithOrderListDto
    {
        public int Id { get; set; }                
        public string CompanyName { get; set; }        
        public string ContactName { get; set; }        
        public string ContactTitle { get; set; }        
        public string Phone { get; set; }                
        public FullAddress FullAddress { get; set; }        
        public string CustomerID { get; set; }
        public List<Order> Orders { get; set; }
        
    }
}

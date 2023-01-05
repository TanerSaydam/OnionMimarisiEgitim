using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnionMimarisi.Domain.Dtos
{
    [XmlRoot(ElementName = "Customers")]
    public class CustomersDto
    {

        [XmlElement(ElementName = "Customer")]
        public List<Customer> Customer { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnionMimarisi.Domain.Dtos
{
    [XmlRoot(ElementName = "Root")]
    public class RootDto
    {

        [XmlElement(ElementName = "Customers")]
        public CustomersDto Customers { get; set; }

        [XmlElement(ElementName = "Orders")]
        public OrdersDto Orders { get; set; }
    }
}

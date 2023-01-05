using OnionMimarisi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnionMimarisi.Domain.Dtos
{
    [XmlRoot(ElementName = "Orders")]
    public class Orders
    {

        [XmlElement(ElementName = "Order")]
        public List<Order> Order { get; set; }
    }
}

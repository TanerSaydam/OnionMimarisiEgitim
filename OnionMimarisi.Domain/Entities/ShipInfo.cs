using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnionMimarisi.Domain.Entities
{
    [XmlRoot(ElementName = "ShipInfo")]
    public class ShipInfo
    {

        public int Id { get; set; }
        [XmlElement(ElementName = "ShipVia")]
        public int ShipVia { get; set; }

        [XmlElement(ElementName = "Freight")]
        public double Freight { get; set; }

        [XmlElement(ElementName = "ShipName")]
        public string ShipName { get; set; }

        [XmlElement(ElementName = "ShipAddress")]
        public string ShipAddress { get; set; }

        [XmlElement(ElementName = "ShipCity")]
        public string ShipCity { get; set; }

        [XmlElement(ElementName = "ShipRegion")]
        public string ShipRegion { get; set; }

        [XmlElement(ElementName = "ShipPostalCode")]
        public int ShipPostalCode { get; set; }

        [XmlElement(ElementName = "ShipCountry")]
        public string ShipCountry { get; set; }

        [XmlAttribute(AttributeName = "ShippedDate")]
        public DateTime ShippedDate { get; set; }

        [XmlText]
        public string? Text { get; set; }
    }
}

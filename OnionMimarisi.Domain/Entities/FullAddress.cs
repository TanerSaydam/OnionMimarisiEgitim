using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnionMimarisi.Domain.Entities
{
    [XmlRoot(ElementName = "FullAddress")]
    public class FullAddress
    {
        public int Id { get; set; }

        [XmlElement(ElementName = "Address")]
        public string Address { get; set; }

        [XmlElement(ElementName = "City")]
        public string City { get; set; }

        [XmlElement(ElementName = "Region")]
        public string Region { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public int PostalCode { get; set; }

        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
    }
}

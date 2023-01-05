using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnionMimarisi.Domain.Entities
{
    [XmlRoot(ElementName = "Customer")]
    public class Customer
    {
        public int Id { get; set; }

        [XmlElement(ElementName = "CompanyName")]
        public string CompanyName { get; set; }

        [XmlElement(ElementName = "ContactName")]
        public string ContactName { get; set; }

        [XmlElement(ElementName = "ContactTitle")]
        public string ContactTitle { get; set; }

        [XmlElement(ElementName = "Phone")]
        public string Phone { get; set; }

        [XmlElement(ElementName = "FullAddress")]
        public FullAddress FullAddress { get; set; }

        [XmlAttribute(AttributeName = "CustomerID")]
        public string CustomerID { get; set; }

        [XmlText]
        public string? Text { get; set; }

        [XmlElement(ElementName = "Fax")]
        public string? Fax { get; set; }
    }
}

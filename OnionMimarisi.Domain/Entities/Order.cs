using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnionMimarisi.Domain.Entities
{
    [XmlRoot(ElementName = "Order")]
    public class Order
    {

        public int Id { get; set; }
        [XmlElement(ElementName = "CustomerID")]
        public string CustomerID { get; set; }

        [XmlElement(ElementName = "EmployeeID")]
        public int EmployeeID { get; set; }

        [XmlElement(ElementName = "OrderDate")]
        public DateTime OrderDate { get; set; }

        [XmlElement(ElementName = "RequiredDate")]
        public DateTime RequiredDate { get; set; }

        [XmlElement(ElementName = "ShipInfo")]
        public ShipInfo ShipInfo { get; set; }
    }

}

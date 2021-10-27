using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nop.Web.Models.Order
{
    public class MakeAnOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        [XmlIgnore]
        public IFormFile Image { get; set; }
        public string FileName { get; set; }
    }
}

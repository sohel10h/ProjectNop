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
        public string AttrName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    public class MakeAnOrderMobile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string FileName { get; set; }
        public string AttrName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    public class MakeAnOrderMobileList 
    {
        public int CustomerId { get; set; }
        public List<MakeAnOrderMobile> Orders { get; set; }

        public int AddressId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string PhoneNumber { get; set; }







    }
    public class MakeAnOrderResult 
    {
        public bool Result { get; set; }
        public int OrderId { get; set; }
        public string Message { get; set; }
    }


}

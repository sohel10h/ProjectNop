using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Areas.Admin.Models.SallerItem
{
    public partial record SallerItemModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Admin.SallerItem.Fields.ID")]
        public string ID { get; set; }
        [NopResourceDisplayName("Admin.SallerItem.Fields.Name")]
        public string Name { get; set; }
        [NopResourceDisplayName("Admin.SallerItem.Fields.CustomerId")]
        public int CustomerId { get; set; }
        [NopResourceDisplayName("Admin.SallerItem.Fields.Address")]
        public string Address { get; set; }
        [NopResourceDisplayName("Admin.SallerItem.Fields.ProductName")]
        public string ProductName { get; set; }
        [NopResourceDisplayName("Admin.SallerItem.Fields.ProductPrice")]
        public string ProductPrice { get; set; }
        [NopResourceDisplayName("Admin.SallerItem.Fields.ImageString")]
        public string ImageString { get; set; }
        [NopResourceDisplayName("Admin.SallerItem.Fields.ProductStatus")]
        public bool ProductStatus { get; set; }
        [NopResourceDisplayName("Admin.SallerItem.Fields.ProductDescription")]
        public string ProductDescription { get; set; }
    }
}

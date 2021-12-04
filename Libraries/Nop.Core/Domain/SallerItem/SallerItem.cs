using Nop.Core.Domain.Common;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Seo;
using Nop.Core.Domain.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.SallerItems
{

    public partial class SallerItem : BaseEntity, ILocalizedEntity, ISlugSupported
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageString { get; set; }
        public int ProductStatus { get; set; }
        public string ProductDescription { get; set; }
    }
}

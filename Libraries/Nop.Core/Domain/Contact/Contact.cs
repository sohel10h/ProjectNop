using System;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Discounts;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Security;
using Nop.Core.Domain.Seo;
using Nop.Core.Domain.Stores;

namespace Nop.Core.Domain.Contacts
{
    /// <summary>
    /// Represents a Contact
    /// </summary>
    public partial class Contact : BaseEntity, ILocalizedEntity, ISlugSupported, IStoreMappingSupported, IAclSupported
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
        public string Address { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int Type { get; set; }
        public int StoreId { get; set; }
        public DateTime VisitDate { get; set; }
        public int Status { get; set; }
        public bool SubjectToAcl { get; set; }
        public bool LimitedToStores { get; set; }
    }
}
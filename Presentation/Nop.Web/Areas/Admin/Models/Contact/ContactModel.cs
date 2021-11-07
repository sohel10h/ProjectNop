using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Web.Areas.Admin.Models.Contact
{
    /// <summary>
    /// Represents a Contact
    /// </summary>
    public partial record ContactModel : BaseNopEntityModel, IStoreMappingSupportedModel
    {
        #region Ctor

        public ContactModel()
        {
            SelectedStoreIds = new List<int>();
            AvailableStores = new List<SelectListItem>();
        }

        #endregion
        [NopResourceDisplayName("Admin.Contact.Fields.Name")]
        public string Name { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.Deleted")]
        public bool Deleted { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.Address")]
        public string Address { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.CreatedOnUtc")]
        public DateTime CreatedOnUtc { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.ID")]
        public int ID { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.Phone")]
        public string Phone { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.Email")]
        public string Email { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.Subject")]
        public string Subject { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.Message")]
        public string Message { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.Type")]
        public int Type { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.StoreId")]
        public int StoreId { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.VisitDate")]
        public DateTime VisitDate { get; set; }
        [NopResourceDisplayName("Admin.Contact.Fields.Status")]
        public int Status { get; set; }
        public IList<int> SelectedStoreIds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<SelectListItem> AvailableStores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
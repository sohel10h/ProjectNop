using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Contact
{
    /// <summary>
    /// Represents a Contact
    /// </summary>
    public partial record ContactModel : BaseNopEntityModel
    {
        #region Ctor

        public ContactModel()
        {
            SelectedStoreIds = new List<int>();
            AvailableStores = new List<SelectListItem>();
        }

        #endregion
        [NopResourceDisplayName("Contact.Fields.Name")]
        public string Name { get; set; }
        [NopResourceDisplayName("Contact.Fields.Deleted")]
        public bool Deleted { get; set; }
        [NopResourceDisplayName("Contact.Fields.Address")]
        public string Address { get; set; }
        [NopResourceDisplayName("Contact.Fields.CreatedOnUtc")]
        public DateTime CreatedOnUtc { get; set; }
        [NopResourceDisplayName("Contact.Fields.ID")]
        public int ID { get; set; }
        [NopResourceDisplayName("Contact.Fields.Phone")]
        public string Phone { get; set; }
        [NopResourceDisplayName("Contact.Fields.Email")]
        public string Email { get; set; }
        [NopResourceDisplayName("Contact.Fields.Subject")]
        public string Subject { get; set; }
        [NopResourceDisplayName("Contact.Fields.Message")]
        public string Message { get; set; }
        [NopResourceDisplayName("Contact.Fields.Type")]
        public int Type { get; set; }
        [NopResourceDisplayName("Contact.Fields.StoreId")]
        public int StoreId { get; set; }
        [NopResourceDisplayName("Contact.Fields.VisitDate")]
        public DateTime VisitDate { get; set; }
        [NopResourceDisplayName("Contact.Fields.Status")]
        public int Status { get; set; }
        public IList<int> SelectedStoreIds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<SelectListItem> AvailableStores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
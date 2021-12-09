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
        [NopResourceDisplayName("Contact.Fields.Name")]
        [Required]
        public string Name { get; set; }


        [NopResourceDisplayName("Contact.Fields.Address")]
        [Required]
        public string Address { get; set; }


        [NopResourceDisplayName("Contact.Fields.CreatedOnUtc")]
        public DateTime CreatedOnUtc { get; set; }


        [NopResourceDisplayName("Contact.Fields.ID")]
        public int ID { get; set; }


        [NopResourceDisplayName("Contact.Fields.Phone")]
        [Required]
        public string Phone { get; set; }


        [NopResourceDisplayName("Contact.Fields.Email")]
        public string Email { get; set; }


        [NopResourceDisplayName("Contact.Fields.Subject")]
        public string Subject { get; set; }


        [NopResourceDisplayName("Contact.Fields.Message")]
        [Required]
        public string Message { get; set; }



        [NopResourceDisplayName("Contact.Fields.Type")]
        public int Type { get; set; }


        [NopResourceDisplayName("Contact.Fields.StoreId")]
        public int StoreId { get; set; }


        [NopResourceDisplayName("Contact.Fields.VisitDate")]
        public DateTime VisitDate { get; set; }


        [NopResourceDisplayName("Contact.Fields.Status")]
        public int Status { get; set; }

        [NopResourceDisplayName("Contact.Fields.NIDNumber")]
        [Required]
        public string NIDNumber { get; set; }


        [NopResourceDisplayName("Contact.Fields.Product")]
        [Required]
        public string Product { get; set; }

        [NopResourceDisplayName("Contact.Fields.ProblemDetails")]
        public string ProblemDetails { get; set; }



        [NopResourceDisplayName("Contact.Fields.Deleted")]
        public bool Deleted { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Validators;
using Nop.Services.Localization;
using Nop.Data;
using FluentValidation;
using Nop.Web.Areas.Admin.Models.Contact;
using Nop.Core.Domain.Contacts;

namespace Nop.Web.Areas.Admin.Validators.Contacts
{
    /// <summary>
    /// Represents a Contact
    /// </summary>
    public partial class ContactValidator : BaseNopValidator<ContactModel>
    {
        public ContactValidator(ILocalizationService localizationService, INopDataProvider dataProvider)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Contact.Fields.Name.Required"));

            RuleFor(x => x.Message)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Contact.Fields.Message.Required"));

            //blog tags should not contain dots
            //current implementation does not support it because it can be handled as file extension
            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Contact.Fields.Phone.Required"));

            SetDatabaseValidationRules<Contact>(dataProvider);
        }
    }
}
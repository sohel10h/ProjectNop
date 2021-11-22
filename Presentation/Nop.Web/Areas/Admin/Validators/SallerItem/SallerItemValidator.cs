using FluentValidation;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Areas.Admin.Models.SallerItem;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Admin.Validators.SallerItem
{
    public partial class SallerItemValidator : BaseNopValidator<SallerItemModel>
    {
        public SallerItemValidator(ILocalizationService localizationService, INopDataProvider dataProvider)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Contact.Fields.Name.Required"));

            RuleFor(x => x.CustomerId)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Contact.Fields.Message.Required"));
            RuleFor(x => x.CustomProperties)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Contact.Fields.Phone.Required"));

            //SetDatabaseValidationRules<SallerItem>(dataProvider);
        }
    }
}

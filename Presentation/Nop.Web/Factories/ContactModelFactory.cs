using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Domain.Contacts;
using Nop.Core.Domain.Localization;
using Nop.Data;
using Nop.Services.Contacts;
using Nop.Services.Localization;
using Nop.Services.Seo;
using Nop.Services.Stores;
using Nop.Web.Areas.Admin.Factories;
using Nop.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Nop.Web.Areas.Admin.Models.Contact;
using Nop.Web.Framework.Factories;
using Nop.Web.Framework.Models.Extensions;

namespace Nop.Web.Factories
{
    /// <summary>
    /// Contact service
    /// </summary>
    public partial class ContactModelFactory : IContactModelFactory
    {
        #region Fields
        private readonly IContactService _contactService;
        private readonly IAclSupportedModelFactory _aclSupportedModelFactory;
        private readonly IActionContextAccessor _actionContextAccessor;
        private readonly IBaseAdminModelFactory _baseAdminModelFactory;
        private readonly ILocalizationService _localizationService;
        private readonly ILocalizedModelFactory _localizedModelFactory;
        private readonly IStoreMappingSupportedModelFactory _storeMappingSupportedModelFactory;
        private readonly IUrlHelperFactory _urlHelperFactory;
        private readonly IUrlRecordService _urlRecordService;
        private readonly IWebHelper _webHelper;
        #endregion

        #region Ctor

        public ContactModelFactory(IContactService contactService,
                        IAclSupportedModelFactory aclSupportedModelFactory,
            IActionContextAccessor actionContextAccessor,
            IBaseAdminModelFactory baseAdminModelFactory,
            ILocalizationService localizationService,
            ILocalizedModelFactory localizedModelFactory,
            IStoreMappingSupportedModelFactory storeMappingSupportedModelFactory,
            IUrlHelperFactory urlHelperFactory,
            IUrlRecordService urlRecordService,
            IWebHelper webHelper)
        {
            _aclSupportedModelFactory = aclSupportedModelFactory;
            _actionContextAccessor = actionContextAccessor;
            _baseAdminModelFactory = baseAdminModelFactory;
            _localizationService = localizationService;
            _localizedModelFactory = localizedModelFactory;
            _storeMappingSupportedModelFactory = storeMappingSupportedModelFactory;
            _urlHelperFactory = urlHelperFactory;
            _urlRecordService = urlRecordService;
            _webHelper = webHelper;
            _contactService = contactService;
        }
        /// <summary>
        /// Prepare contact post model
        /// </summary>
        /// <param name="model">Blog post model</param>
        /// <param name="contact">Blog post entity</param>
        /// <param name="prepareComments">Whether to prepare contact comments</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task PrepareContactModelAsync(ContactModel model, Contact contact)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            model.Id = contact.Id;
            model.Name = contact.Name;
            model.Message = contact.Message;
            model.Address = contact.Address;
            model.CreatedOnUtc = contact.CreatedOnUtc;
            model.Phone = contact.Phone;
        }
        #endregion
        public virtual async Task<ContactListModel> PrepareContactListModelAsync(ContactSearchModel searchModel)
        {
            if (searchModel == null)
                throw new ArgumentNullException(nameof(searchModel));

            //get Contacts
            var contacts = await _contactService.GetAllContactsAsync();

            var pagedContacts = contacts.ToPagedList(searchModel);

            //prepare grid model
            var model = await new ContactListModel().PrepareToGridAsync(searchModel, pagedContacts, () =>
            {
                return pagedContacts.SelectAwait(async Contact =>
                {
                    //fill in model values from the entity
                    var ContactModel = Contact.ToModel<ContactModel>();

                    //little performance optimization: ensure that "Body" is not returned
                    //ContactModel.Body = string.Empty;

                    //ContactModel.SeName = await _urlRecordService.GetSeNameAsync(Contact, 0, true, false);

                    //if (!string.IsNullOrEmpty(ContactModel.SystemName))
                    //    ContactModel.ContactName = ContactModel.SystemName;
                    //else
                    //    ContactModel.ContactName = ContactModel.Title;

                    return ContactModel;
                });
            });
            return null;
        }

        public virtual async Task<ContactModel> PrepareContactModelAsync(ContactModel model, Contact contact, bool excludeProperties = false)
        {
            Action<ContactLocalizedModel, int> localizedModelConfiguration = null;

            if (contact != null)
            {
                //fill in model values from the entity
                if (model == null)
                {
                    model = contact.ToModel<ContactModel>();
                    //model.SeName = await _urlRecordService.GetSeNameAsync(contact, 0, true, false);
                }

                //model.Url = _urlHelperFactory.GetUrlHelper(_actionContextAccessor.ActionContext)
                //    .RouteUrl("Contact", new { SeName = await _urlRecordService.GetSeNameAsync(contact) }, _webHelper.GetCurrentRequestProtocol());

                //define localized model configuration action
                localizedModelConfiguration = async (locale, languageId) =>
                {
                    locale.Title = await _localizationService.GetLocalizedAsync(contact, entity => entity.Name, languageId, false, false);
                    locale.Body = await _localizationService.GetLocalizedAsync(contact, entity => entity.Message, languageId, false, false);
                    locale.MetaKeywords = await _localizationService.GetLocalizedAsync(contact, entity => entity.Subject, languageId, false, false);
                    locale.MetaDescription = await _localizationService.GetLocalizedAsync(contact, entity => entity.Message, languageId, false, false);
                    locale.MetaTitle = await _localizationService.GetLocalizedAsync(contact, entity => entity.Subject, languageId, false, false);
                    locale.SeName = await _urlRecordService.GetSeNameAsync(contact, languageId, false, false);
                };
            }

            //prepare localized models
            //if (!excludeProperties)
            //    model.Locales = await _localizedModelFactory.PrepareLocalizedModelsAsync(localizedModelConfiguration);

            ////prepare available Contact templates
            //await _baseAdminModelFactory.PrepareContactTemplatesAsync(model.AvailableContactTemplates, false);

            //prepare model customer roles
            //await _aclSupportedModelFactory.PrepareModelCustomerRolesAsync(model, contact, excludeProperties);

            //prepare model stores
            await _storeMappingSupportedModelFactory.PrepareModelStoresAsync(model, contact, excludeProperties);

            return model;
        }
    }
}
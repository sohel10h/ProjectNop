using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Nop.Core;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Contacts;
using Nop.Services.Localization;
using Nop.Services.Seo;
using Nop.Services.Contacts;
using Nop.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Nop.Web.Areas.Admin.Models.Contact;
using Nop.Web.Framework.Extensions;
using Nop.Web.Framework.Factories;
using Nop.Web.Framework.Models.Extensions;

namespace Nop.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the Contact model factory implementation
    /// </summary>
    public partial class ContactModelFactory : IContactModelFactory
    {
        #region Fields

        private readonly CatalogSettings _catalogSettings;
        private readonly IAclSupportedModelFactory _aclSupportedModelFactory;
        private readonly IActionContextAccessor _actionContextAccessor;
        private readonly IBaseAdminModelFactory _baseAdminModelFactory;
        private readonly ILocalizationService _localizationService;
        private readonly ILocalizedModelFactory _localizedModelFactory;
        private readonly IStoreMappingSupportedModelFactory _storeMappingSupportedModelFactory;
        private readonly IContactService _ContactService;
        private readonly IUrlHelperFactory _urlHelperFactory;
        private readonly IUrlRecordService _urlRecordService;
        private readonly IWebHelper _webHelper;

        #endregion

        #region Ctor

        public ContactModelFactory(CatalogSettings catalogSettings,
            IAclSupportedModelFactory aclSupportedModelFactory,
            IActionContextAccessor actionContextAccessor,
            IBaseAdminModelFactory baseAdminModelFactory,
            ILocalizationService localizationService,
            ILocalizedModelFactory localizedModelFactory,
            IStoreMappingSupportedModelFactory storeMappingSupportedModelFactory,
            IContactService ContactService,
            IUrlHelperFactory urlHelperFactory,
            IUrlRecordService urlRecordService,
            IWebHelper webHelper)
        {
            _catalogSettings = catalogSettings;
            _aclSupportedModelFactory = aclSupportedModelFactory;
            _actionContextAccessor = actionContextAccessor;
            _baseAdminModelFactory = baseAdminModelFactory;
            _localizationService = localizationService;
            _localizedModelFactory = localizedModelFactory;
            _storeMappingSupportedModelFactory = storeMappingSupportedModelFactory;
            _ContactService = ContactService;
            _urlHelperFactory = urlHelperFactory;
            _urlRecordService = urlRecordService;
            _webHelper = webHelper;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prepare Contact search model
        /// </summary>
        /// <param name="searchModel">Contact search model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic search model
        /// </returns>
        public virtual async Task<ContactSearchModel> PrepareContactSearchModelAsync(ContactSearchModel searchModel)
        {
            if (searchModel == null)
                throw new ArgumentNullException(nameof(searchModel));

            //prepare available stores
            await _baseAdminModelFactory.PrepareStoresAsync(searchModel.AvailableStores);

            searchModel.HideStoresList = _catalogSettings.IgnoreStoreLimitations || searchModel.AvailableStores.SelectionIsNotPossible();

            //prepare page parameters
            searchModel.SetGridPageSize();

            return searchModel;
        }

        /// <summary>
        /// Prepare paged Contact list model
        /// </summary>
        /// <param name="searchModel">Contact search model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic list model
        /// </returns>
        public virtual async Task<ContactListModel> PrepareContactListModelAsync(ContactSearchModel searchModel)
        {
            if (searchModel == null)
                throw new ArgumentNullException(nameof(searchModel));

            //get Contacts
            var Contacts = await _ContactService.GetAllContactsAsync();

            var pagedContacts = Contacts.ToPagedList(searchModel);

            //prepare grid model
            var model = await new ContactListModel().PrepareToGridAsync(searchModel, pagedContacts, () =>
            {
                return pagedContacts.SelectAwait(async Contact =>
                {
                    //fill in model values from the entity
                    var ContactModel = Contact.ToModel<ContactModel>();
                    return ContactModel;
                });
            });

            return model;
        }

        /// <summary>
        /// Prepare Contact model
        /// </summary>
        /// <param name="model">Contact model</param>
        /// <param name="Contact">Contact</param>
        /// <param name="excludeProperties">Whether to exclude populating of some properties of model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic model
        /// </returns>
        public virtual async Task<ContactModel> PrepareContactModelAsync(ContactModel model, Contact Contact, bool excludeProperties = false)
        {
            Action<ContactLocalizedModel, int> localizedModelConfiguration = null;

            if (Contact != null)
            {
                //fill in model values from the entity
                if (model == null)
                {
                    model = Contact.ToModel<ContactModel>();
                }

                //model.Url = _urlHelperFactory.GetUrlHelper(_actionContextAccessor.ActionContext)
                    //.RouteUrl("Contact", new { SeName = await _urlRecordService.GetSeNameAsync(Contact) }, _webHelper.GetCurrentRequestProtocol());

                //define localized model configuration action
                localizedModelConfiguration = async (locale, languageId) =>
                {
                    //locale.Title = await _localizationService.GetLocalizedAsync(Contact, entity => entity.Title, languageId, false, false);
                    //locale.Body = await _localizationService.GetLocalizedAsync(Contact, entity => entity.Body, languageId, false, false);
                    //locale.MetaKeywords = await _localizationService.GetLocalizedAsync(Contact, entity => entity.MetaKeywords, languageId, false, false);
                    //locale.MetaDescription = await _localizationService.GetLocalizedAsync(Contact, entity => entity.MetaDescription, languageId, false, false);
                    //locale.MetaTitle = await _localizationService.GetLocalizedAsync(Contact, entity => entity.MetaTitle, languageId, false, false);
                    locale.SeName = await _urlRecordService.GetSeNameAsync(Contact, languageId, false, false);
                };
            }

            //set default values for the new model
            //if (Contact == null)
            //{
            //    model.DisplayOrder = 1;
            //    model.Published = true;
            //}

            //prepare localized models
            //if (!excludeProperties)
            //    model.Locales = await _localizedModelFactory.PrepareLocalizedModelsAsync(localizedModelConfiguration);

            ////prepare available Contact templates
            //await _baseAdminModelFactory.PrepareContactTemplatesAsync(model.AvailableContactTemplates, false);

            ////prepare model customer roles
            //await _aclSupportedModelFactory.PrepareModelCustomerRolesAsync(model, Contact, excludeProperties);

            //prepare model stores
            await _storeMappingSupportedModelFactory.PrepareModelStoresAsync(model, Contact, excludeProperties);

            return model;
        }

        #endregion
    }
}
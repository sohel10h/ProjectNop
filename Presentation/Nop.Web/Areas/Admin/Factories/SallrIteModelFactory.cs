using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Nop.Core;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.SallerItems;
using Nop.Services.Localization;
using Nop.Services.Seo;
using Nop.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Nop.Web.Areas.Admin.Models.SallerItem;
using Nop.Web.Framework.Extensions;
using Nop.Web.Framework.Factories;
using Nop.Web.Framework.Models.Extensions;
using Nop.Web.Areas.Admin.Models.Contact;
using Nop.Services.Saller;

namespace Nop.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the SallerItem model factory implementation
    /// </summary>
    public partial class SallerItemModelFactory : ISallerItemModelFactory
    {
        #region Fields

        private readonly CatalogSettings _catalogSettings;
        private readonly IAclSupportedModelFactory _aclSupportedModelFactory;
        private readonly IActionContextAccessor _actionContextAccessor;
        private readonly IBaseAdminModelFactory _baseAdminModelFactory;
        private readonly ILocalizationService _localizationService;
        private readonly ILocalizedModelFactory _localizedModelFactory;
        private readonly IStoreMappingSupportedModelFactory _storeMappingSupportedModelFactory;
        private readonly ISallerService _SallerItemService;
        private readonly IUrlHelperFactory _urlHelperFactory;
        private readonly IUrlRecordService _urlRecordService;
        private readonly IWebHelper _webHelper;

        #endregion

        #region Ctor

        public SallerItemModelFactory(CatalogSettings catalogSettings,
            IAclSupportedModelFactory aclSupportedModelFactory,
            IActionContextAccessor actionContextAccessor,
            IBaseAdminModelFactory baseAdminModelFactory,
            ILocalizationService localizationService,
            ILocalizedModelFactory localizedModelFactory,
            IStoreMappingSupportedModelFactory storeMappingSupportedModelFactory,
            ISallerService SallerItemService,
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
            _SallerItemService = SallerItemService;
            _urlHelperFactory = urlHelperFactory;
            _urlRecordService = urlRecordService;
            _webHelper = webHelper;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prepare SallerItem search model
        /// </summary>
        /// <param name="searchModel">SallerItem search model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic search model
        /// </returns>
        public virtual async Task<SallerItemSearchModel> PrepareSallerItemSearchModelAsync(SallerItemSearchModel searchModel)
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
        /// Prepare paged SallerItem list model
        /// </summary>
        /// <param name="searchModel">SallerItem search model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic list model
        /// </returns>
        public virtual async Task<SallerItemListModel> PrepareSallerItemListModelAsync(SallerItemSearchModel searchModel)
        {
            if (searchModel == null)
                throw new ArgumentNullException(nameof(searchModel));

            //get SallerItems
            var SallerItems = await _SallerItemService.GetAllSallerItemsListAsync();

            var pagedSallerItems = SallerItems.ToPagedList(searchModel);


            var model = new SallerItemListModel().PrepareToGrid(searchModel, pagedSallerItems, () =>
            {
                return pagedSallerItems.Select(item =>
                {
                    //fill in model values from the entity
                    var SallerItemModel = new SallerItemModel
                    {
                        ID = item.ID.ToString(),
                        Name = item.ProductName,
                        ProductPrice=item.ProductPrice.ToString(),
                        ProductStatus=item.ProductStatus


                    };
                    return SallerItemModel;
                });
            });

            return model;
        }

        /// <summary>
        /// Prepare SallerItem model
        /// </summary>
        /// <param name="model">SallerItem model</param>
        /// <param name="SallerItem">SallerItem</param>
        /// <param name="excludeProperties">Whether to exclude populating of some properties of model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic model
        /// </returns>
        public virtual async Task<SallerItemModel> PrepareSallerItemModelAsync(SallerItemModel model, SallerItem SallerItem, bool excludeProperties = false)
        {
            Action<SallerItemLocalizedModel, int> localizedModelConfiguration = null;

            if (SallerItem != null)
            {
                //fill in model values from the entity
                if (model == null)
                {
                    model = SallerItem.ToModel<SallerItemModel>();
                }

                //model.Url = _urlHelperFactory.GetUrlHelper(_actionContextAccessor.ActionContext)
                //.RouteUrl("SallerItem", new { SeName = await _urlRecordService.GetSeNameAsync(SallerItem) }, _webHelper.GetCurrentRequestProtocol());

                //define localized model configuration action
                localizedModelConfiguration = async (locale, languageId) =>
                {
                    //locale.Title = await _localizationService.GetLocalizedAsync(SallerItem, entity => entity.Title, languageId, false, false);
                    //locale.Body = await _localizationService.GetLocalizedAsync(SallerItem, entity => entity.Body, languageId, false, false);
                    //locale.MetaKeywords = await _localizationService.GetLocalizedAsync(SallerItem, entity => entity.MetaKeywords, languageId, false, false);
                    //locale.MetaDescription = await _localizationService.GetLocalizedAsync(SallerItem, entity => entity.MetaDescription, languageId, false, false);
                    //locale.MetaTitle = await _localizationService.GetLocalizedAsync(SallerItem, entity => entity.MetaTitle, languageId, false, false);
                    locale.SeName = await _urlRecordService.GetSeNameAsync(SallerItem, languageId, false, false);
                };
            }

            //set default values for the new model
            //if (SallerItem == null)
            //{
            //    model.DisplayOrder = 1;
            //    model.Published = true;
            //}

            //prepare localized models
            //if (!excludeProperties)
            //    model.Locales = await _localizedModelFactory.PrepareLocalizedModelsAsync(localizedModelConfiguration);

            ////prepare available SallerItem templates
            //await _baseAdminModelFactory.PrepareSallerItemTemplatesAsync(model.AvailableSallerItemTemplates, false);

            ////prepare model customer roles
            //await _aclSupportedModelFactory.PrepareModelCustomerRolesAsync(model, SallerItem, excludeProperties);

            //prepare model stores
            //await _storeMappingSupportedModelFactory.PrepareModelStoresAsync(model, SallerItem, excludeProperties);

            return model;
        }

        #endregion
    }
}
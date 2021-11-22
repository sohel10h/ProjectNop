
using Nop.Web.Models.Contact;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Topics;
using Nop.Services.Common;
using Nop.Services.Customers;
using Nop.Services.Localization;
using Nop.Services.Logging;
using Nop.Services.Messages;
using Nop.Services.Security;
using Nop.Services.Seo;
using Nop.Services.Stores;
using Nop.Services.Topics;
using Nop.Web.Areas.Admin.Factories;
using Nop.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Nop.Web.Areas.Admin.Models.Topics;
using Nop.Web.Framework.Mvc.Filters;
using Nop.Services.Contacts;

namespace Nop.Web.Areas.Admin.Controllers
{
    public class ContractController : BaseAdminController
    {
        #region Fields

        private readonly IContactService _contactService;
        private readonly IAclService _aclService;
        private readonly ICustomerActivityService _customerActivityService;
        private readonly ICustomerService _customerService;
        private readonly ILocalizationService _localizationService;
        private readonly ILocalizedEntityService _localizedEntityService;
        private readonly INotificationService _notificationService;
        private readonly IPermissionService _permissionService;
        private readonly IStoreMappingService _storeMappingService;
        private readonly IStoreService _storeService;
        private readonly ITopicModelFactory _topicModelFactory;
        private readonly ITopicService _topicService;
        private readonly IUrlRecordService _urlRecordService;
        private readonly IGenericAttributeService _genericAttributeService;
        private readonly IWorkContext _workContext;



        //private readonly IContactModelFactory _contactModelFactory;

        #endregion


        public ContractController(IContactService contactService,
           IAclService aclService,
            ICustomerActivityService customerActivityService,
            ICustomerService customerService,
            ILocalizationService localizationService,
            ILocalizedEntityService localizedEntityService,
            INotificationService notificationService,
            IPermissionService permissionService,
            IStoreMappingService storeMappingService,
            IStoreService storeService,
            ITopicModelFactory topicModelFactory,
            ITopicService topicService,
            IUrlRecordService urlRecordService,
            IGenericAttributeService genericAttributeService,
            IWorkContext workContext
            )
        {
            this._contactService = contactService;
            _aclService = aclService;
            _customerActivityService = customerActivityService;
            _customerService = customerService;
            _localizationService = localizationService;
            _localizedEntityService = localizedEntityService;
            _notificationService = notificationService;
            _permissionService = permissionService;
            _storeMappingService = storeMappingService;
            _storeService = storeService;
            _topicModelFactory = topicModelFactory;
            _topicService = topicService;
            _urlRecordService = urlRecordService;
            _genericAttributeService = genericAttributeService;
            _workContext = workContext;
        }
        public async Task<IActionResult> Index(bool showtour = false)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTopics))
                return AccessDeniedView();

            //prepare model
            var model = await _topicModelFactory.PrepareTopicSearchModelAsync(new TopicSearchModel());

            //show configuration tour
            if (showtour)
            {
                var hideCard = await _genericAttributeService.GetAttributeAsync<bool>(await _workContext.GetCurrentCustomerAsync(), NopCustomerDefaults.HideConfigurationStepsAttribute);

                var closeCard = await _genericAttributeService.GetAttributeAsync<bool>(await _workContext.GetCurrentCustomerAsync(), NopCustomerDefaults.CloseConfigurationStepsAttribute);

                if (!hideCard && !closeCard)
                    ViewBag.ShowTour = true;
            }

            return View(model);
        }
        [HttpPost]
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> List()
        {
            var model = await _contactService.GetAllContactsAsync((int)ContactType.Contact);
            return Json(model);
        }
        public async Task<IActionResult> Appoinments()
        {
            return View();

        }
    }
}

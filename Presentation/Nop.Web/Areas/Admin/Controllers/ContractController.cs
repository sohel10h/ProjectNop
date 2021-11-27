
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
using Nop.Web.Areas.Admin.Models.Contact;

namespace Nop.Web.Areas.Admin.Controllers
{
    public class ContractController : BaseAdminController
    {
        #region Fields
        private readonly IContactModelFactory _contactModelFactory;
        #endregion


        public ContractController(
            IContactModelFactory contactModelFactory
            //IGenericAttributeService genericAttributeService,
            //IWorkContext workContext
            )
        {
            this._contactModelFactory = contactModelFactory;
            //this._genericAttributeService = genericAttributeService;
            //this._workContext = workContext;
        }
        public async Task<IActionResult> Index(bool showtour = false)
        {
            //prepare model
            var model = await _contactModelFactory.PrepareContactSearchModelAsync(new ContactSearchModel());

            //show configuration tour
            //if (showtour)
            //{
            //    var hideCard = await _genericAttributeService.GetAttributeAsync<bool>(await _workContext.GetCurrentCustomerAsync(), NopCustomerDefaults.HideConfigurationStepsAttribute);

            //    var closeCard = await _genericAttributeService.GetAttributeAsync<bool>(await _workContext.GetCurrentCustomerAsync(), NopCustomerDefaults.CloseConfigurationStepsAttribute);

            //    if (!hideCard && !closeCard)
            //        ViewBag.ShowTour = true;
            //}

            return View(model);
        }
        [HttpPost]
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> List(ContactSearchModel searchModel)
        {
            //var model = await _contactService.GetAllContactsAsync((int)ContactType.Contact);
            //return Json(model);
            //if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTopics))
            //    return await AccessDeniedDataTablesJson();

            //prepare model
            var model = await _contactModelFactory.PrepareContactListModelAsync(searchModel);
            return Json(model);
        }
        public async Task<IActionResult> Appoinments()
        {
            return View();

        }
    }
}

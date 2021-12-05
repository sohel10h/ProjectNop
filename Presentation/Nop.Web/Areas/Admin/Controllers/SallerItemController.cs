using Microsoft.AspNetCore.Mvc;
using Nop.Web.Areas.Admin.Factories;
using Nop.Web.Areas.Admin.Models.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Areas.Admin.Controllers
{
    public class SallerItemController : BaseAdminController
    {
        #region Fields
        private readonly ISallerItemModelFactory _sallerItemModelFactory;
        #endregion
        public SallerItemController(
            ISallerItemModelFactory sallerItemModelFactory
            //IGenericAttributeService genericAttributeService,
            //IWorkContext workContext
            )
        {
            this._sallerItemModelFactory = sallerItemModelFactory;
            //this._genericAttributeService = genericAttributeService;
            //this._workContext = workContext;
        }
        public async Task<IActionResult> Index()
        {
            //prepare model
            var model = await _sallerItemModelFactory.PrepareSallerItemListModelAsync(new SallerItemSearchModel());
            return View(model);
        }
        [HttpPost]
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> List(SallerItemSearchModel searchModel)
        {
            //var model = await _contactService.GetAllContactsAsync((int)ContactType.Contact);
            //return Json(model);
            //if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTopics))
            //    return await AccessDeniedDataTablesJson();

            //prepare model

            try
            {
                var model = await _sallerItemModelFactory.PrepareSallerItemListModelAsync(searchModel);
                return Json(model);
            }
            catch (Exception exc)
            {


            }

            return Json("");

        }
    }
}

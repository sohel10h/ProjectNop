
using System;
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
using ContactModel = Nop.Web.Areas.Admin.Models.Contact.ContactModel;

namespace Nop.Web.Areas.Admin.Controllers
{
    public class ContractController : BaseAdminController
    {
        #region Fields
        private readonly IContactModelFactory _contactModelFactory;
        private readonly IPermissionService _permissionService;
        private readonly IContactService _contactService;

        #endregion


        public ContractController(
            IContactModelFactory contactModelFactory,
            IPermissionService permissionService,
            IContactService contactService)
        {
            this._contactModelFactory = contactModelFactory;
            this._permissionService = permissionService;
            this._contactService = contactService;
            //this._genericAttributeService = genericAttributeService;
            //this._workContext = workContext;
        }
        public async Task<IActionResult> Index(bool showtour = false)
        {
            var model = await _contactModelFactory.PrepareContactSearchModelAsync(new ContactSearchModel());
            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> List(ContactSearchModel searchModel)
        {
                var model = await _contactModelFactory.PrepareContactListModelAsync(searchModel);
                return Json(model);
        }
        public async Task<IActionResult> Appoinments()
        {
            var model = await _contactModelFactory.PrepareContactSearchModelAsync(new ContactSearchModel());
            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Appoinments(ContactSearchModel searchModel)
        {
            var model = await _contactModelFactory.PrepareContactListModelAsync(searchModel,1);
            return Json(model);
        }



        public virtual async Task<IActionResult> ContractEdit(int id) 
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageCustomers))
                return AccessDeniedView();
            //try to get a country with the specified id
            var contact = await _contactService.GetContactByIdAsync(id);
            if (contact == null)
                return RedirectToAction("Index");
            var model = await _contactModelFactory.PrepareContactModelAsync(null, contact);
            return View(model);
        }


        public virtual async Task<IActionResult> DeleteComplain(int id) 
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageCustomers))
                return AccessDeniedView();
            //try to get a country with the specified id
            var contact = await _contactService.GetContactByIdAsync(id);
            if (contact == null)
                return RedirectToAction("Index");
            await _contactService.DeleteContactAsync(contact);
            return RedirectToAction("Index");

        }


        public virtual async Task<IActionResult> Edit(int id)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageCustomers))
                return AccessDeniedView();
            //try to get a country with the specified id
            var contact = await _contactService.GetContactByIdAsync(id);
            if (contact == null)
                return RedirectToAction("List");
            var model = await _contactModelFactory.PrepareContactModelAsync(null, contact);
            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Edit(int id,string Product)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageCustomers))
                return AccessDeniedView();
            //try to get a country with the specified id
            var contact = await _contactService.GetContactByIdAsync(id);
            if (contact == null)
                return RedirectToAction("List");

            contact.Product = Product;
            await _contactService.UpdateContactAsync(contact);
            //var model = await _contactModelFactory.PrepareContactModelAsync(null, contact);
            return Redirect("/Admin/Contract/Edit/" + id);
        }



    }
}

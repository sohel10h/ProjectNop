using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Contacts;
using Nop.Services.Contacts;
using Nop.Web.Areas.Admin.Controllers;
using Nop.Web.Factories;
using Nop.Web.Framework.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Controllers
{
    public class ContactController : BasePublicController
    {
        #region Fields

        private readonly IContactService _contactService;
        //private readonly IContactModelFactory _contactModelFactory;

        #endregion

        #region Constructors

        public ContactController(
            IContactService contactService
            //IContactModelFactory contactModelFactory
            )
        {
            this._contactService = contactService;
            //this._contactModelFactory = contactModelFactory;
        }

        #endregion
        public async Task<IActionResult> Index()
        {
            var model = await _contactService.GetAllContactsAsync();
            return View("Index", model);

        }
        public virtual async Task<IActionResult> Add()
        {
            var model = new Contact();
            return View(model);
        }

        [HttpPost]
        [ValidateCaptcha]
        public virtual async Task<IActionResult> Add(Contact model, bool captchaValid)
        {
            model.ID = 7;
            await _contactService.InsertContactAsync(model);
            return View(model);
        }
        //public virtual async Task<IActionResult> Edit(int blogPostId)
        //{
        //    var model = await _contactService.GetAllContactsAsync();
        //    return View(model);
        //}

        //[HttpPost]
        //[ValidateCaptcha]
        //public virtual async Task<IActionResult> Edit(int blogPostId, Contact model, bool captchaValid)
        //{
        //    return View(model);
        //}
    }
}

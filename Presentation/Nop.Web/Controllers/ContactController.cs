using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Contacts;
using Nop.Services.Contacts;
using Nop.Web.Areas.Admin.Controllers;
using Nop.Web.Factories;
using Nop.Web.Framework.Mvc.Filters;
using Nop.Web.Models.Contact;
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
        //Contacts
        public async Task<IActionResult> Index()
        {
            var model = await _contactService.GetAllContactsAsync((int)ContactType.Contact);
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
            model.Type = (int)ContactType.Contact;
            await _contactService.InsertContactAsync(model);
            return View(model);
        }
        //Appoinments
        public async Task<IActionResult> Appoinments()
        {
            var model = await _contactService.GetAllContactsAsync((int)ContactType.Appoinment);
            return View("Appoinments", model);

        }
        public virtual async Task<IActionResult> AddAppoinment()
        {
            var model = new Contact();
            return View(model);
        }
        [HttpPost]
        [ValidateCaptcha]
        public virtual async Task<IActionResult> AddAppoinment(Contact model, bool captchaValid)
        {
            model.Type = (int)ContactType.Appoinment;
            await _contactService.InsertContactAsync(model);
            return View(model);
        }

    }
}

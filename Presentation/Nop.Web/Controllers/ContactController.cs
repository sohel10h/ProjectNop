using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Nop.Core;
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
        private readonly IWorkContext _workContext;

        //private readonly IContactModelFactory _contactModelFactory;

        #endregion

        #region Constructors

        public ContactController(
            IContactService contactService,
            IWorkContext workContext
            //IContactModelFactory contactModelFactory
            )
        {
            this._contactService = contactService;
            _workContext = workContext;
            //this._contactModelFactory = contactModelFactory;
        }

        #endregion
        //Contacts
        public async Task<IActionResult> Index()
        {
            var model = await _contactService.GetAllContactsAsync(type:(int)ContactType.Contact);
            return View("Index", model);

        }
        public virtual  IActionResult Add()
        {
            var model = new ContactModel();
            return View(model);
        }

        [HttpPost]
        [ValidateCaptcha]
        public virtual async Task<IActionResult> Add(ContactModel model, bool captchaValid)
        {
            if (ModelState.IsValid)
            {
                var customer = await _workContext.GetCurrentCustomerAsync();

                var contact = new Contact();
                contact.Name = model.Name;
                contact.Address = model.Address;
                contact.Phone = model.Phone;
                contact.Message = model.Message;
                contact.Product = model.Product;
                contact.CustomerId = customer.Id;
                contact.NIDNumber = model.NIDNumber;
                contact.Type = (int)ContactType.Contact;
                await _contactService.InsertContactAsync(contact);
                return Redirect("Add");
            }
            else {
                return View(model);
            
            }
        }




        //Appoinments
        public async Task<IActionResult> Appoinments()
        {
            var customer = await _workContext.GetCurrentCustomerAsync();
            var model = await _contactService.GetAllContactsAsync(customerId: customer.Id, type: (int)ContactType.Appoinment);
            return View("Appoinments", model);
        }


        public virtual  IActionResult AddAppoinment()
        {
            var model = new ContactModel();
            model.VisitDate = DateTime.Now.Date;
            return View(model);
        }
        [HttpPost]
        [ValidateCaptcha]
        public virtual async Task<IActionResult> AddAppoinment(ContactModel model, bool captchaValid)
        {
                var customer = await _workContext.GetCurrentCustomerAsync();
                var contact = new Contact();
                contact.Name = model.Name;
                contact.Address = model.Address;
                contact.Phone = model.Phone;
                contact.Message = model.Message;
                contact.Product = model.Product;
                contact.NIDNumber = model.NIDNumber;
                contact.VisitDate = model.VisitDate;
                contact.Email = model.Email;
                contact.CustomerId = customer.Id;
                contact.Type = (int)ContactType.Appoinment;
                await _contactService.InsertContactAsync(contact);
                return Redirect("/Contact/Appoinments");
        }

    }
}

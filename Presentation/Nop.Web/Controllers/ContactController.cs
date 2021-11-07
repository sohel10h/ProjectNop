using Microsoft.AspNetCore.Mvc;
using Nop.Services.Contacts;
using Nop.Web.Areas.Admin.Controllers;
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

        #endregion

        #region Constructors

        public ContactController(IContactService contactService)
        {
            this._contactService = contactService;
        }

        #endregion
        public IActionResult Index()
        {
            var model =  _contactService.GetAllContactsAsync();
            return View(model);
        }
    }
}

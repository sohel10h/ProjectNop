using Microsoft.AspNetCore.Mvc;
using Nop.Services.Contacts;
using Nop.Web.Models.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Areas.Admin.Controllers
{
    public class ContractController : BaseAdminController
    {
        #region Fields

        private readonly IContactService _contactService;
        //private readonly IContactModelFactory _contactModelFactory;

        #endregion


        public ContractController(IContactService contactService
            //IContactModelFactory contactModelFactory
            )
        {
            this._contactService = contactService;
            //this._contactModelFactory = contactModelFactory;
        }
        public async Task<IActionResult> Index()
        {
            return View();
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

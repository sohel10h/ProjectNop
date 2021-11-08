using Microsoft.AspNetCore.Mvc;
using Nop.Services.Contacts;
using Nop.Web.Areas.Admin.Controllers;
using Nop.Web.Factories;
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
            //var model = _contactModelFactory.PrepareContactListModelAsync();
            //return View(model);
            return View("Index", model);

        }
    }

        //public class ContactController : BasePublicController
        //{
        //    #region Fields

        //    private readonly IContactService _contactService;
        //    private readonly IContactModelFactory _contactModelFactory;
        //    #endregion

        //    #region Constructors

        //    public ContactController(IContactService contactService, IContactModelFactory contactModelFactory)
        //    {
        //        this._contactService = contactService;
        //        _contactModelFactory = contactModelFactory;
        //    }

        //    #endregion
        //    public virtual async Task<IActionResult> Index()
        //    {
        //        var model = _contactModelFactory.PrepareContactListModelAsync();
        //        return View(model);
        //    }
        //}
    

}

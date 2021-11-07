using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Domain.Contacts;
using Nop.Core.Domain.Localization;
using Nop.Data;
using Nop.Services.Contacts;
using Nop.Services.Stores;
using Nop.Web.Areas.Admin.Models.Contact;

namespace Nop.Web.Factories
{
    /// <summary>
    /// Contact service
    /// </summary>
    public partial class ContactModelFactory : IContactModelFactory
    {
        #region Fields
        private readonly IContactService _contactService;
        private readonly IWorkContext _workContext;
        #endregion

        #region Ctor

        public ContactModelFactory(IContactService contactService,
                        IWorkContext workContext)
        {
            _workContext = workContext;
            _contactService = contactService;
        }
        /// <summary>
        /// Prepare contact post model
        /// </summary>
        /// <param name="model">Blog post model</param>
        /// <param name="contact">Blog post entity</param>
        /// <param name="prepareComments">Whether to prepare contact comments</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task PrepareContactModelAsync(ContactModel model, Contact contact)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            model.Id = contact.Id;
            model.Name = contact.Name;
            model.Message = contact.Message;
            model.Address = contact.Address;
            model.CreatedOnUtc = contact.CreatedOnUtc;
            model.Phone = contact.Phone;
        }
        #endregion
        public virtual async Task<ContactListModel> PrepareContactListModelAsync()
        {
            var language = await _workContext.GetWorkingLanguageAsync();
            var contacts = await _contactService.GetAllContactsAsync();
            var model = new ContactListModel
            {
                WorkingLanguageId = language.Id,
                Contacts = await contacts.SelectAwait(async contact =>
                {
                    var contactModel = new ContactModel();
                    await PrepareContactModelAsync(contactModel, contact, false);
                    return contactModel;
                }).ToListAsync()
            };
            return model;
        }

        public Task PrepareContactModelAsync(ContactModel model, Contact contact, bool prepareComments)
        {
            throw new NotImplementedException();
        }
    }
}
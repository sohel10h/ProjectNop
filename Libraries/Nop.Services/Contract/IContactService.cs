using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Domain.Contacts;

namespace Nop.Services.Contacts
{
    /// <summary>
    /// Contact service interface
    /// </summary>
    public partial interface IContactService
    {
        #region Contact posts

        /// <summary>
        /// Deletes a contact post
        /// </summary>
        /// <param name="contact">Contact post</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task DeleteContactAsync(Contact contact);

        /// <summary>
        /// Gets a contact post
        /// </summary>
        /// <param name="contactId">Contact post identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the contact post
        /// </returns>
        Task<Contact> GetContactByIdAsync(int contactId);

        /// <summary>
        /// Gets all contact posts
        /// </summary>
        /// <param name="storeId">The store identifier; pass 0 to load all records</param>
        /// <param name="languageId">Language identifier; 0 if you want to get all records</param>
        /// <param name="dateFrom">Filter by created date; null if you want to get all records</param>
        /// <param name="dateTo">Filter by created date; null if you want to get all records</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <param name="title">Filter by contact post title</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the contact posts
        /// </returns>
        Task<IList<Contact>> GetAllContactsListAsync(int type = 0, int pageIndex = 0, int pageSize = int.MaxValue);
        Task<IPagedList<Contact>> GetAllContactsAsync(int type = 0, int pageIndex = 0, int pageSize = int.MaxValue);



        /// <summary>
        /// Inserts a contact post
        /// </summary>
        /// <param name="contact">Contact post</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task InsertContactAsync(Contact contact);

        /// <summary>
        /// Updates the contact post
        /// </summary>
        /// <param name="contact">Contact post</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task UpdateContactAsync(Contact contact);

        //TODO: migrate to an extension method
        /// <summary>
        /// Get a value indicating whether a contact post is available now (availability dates)
        /// </summary>
        /// <param name="contact">Contact post</param>
        /// <param name="dateTime">Datetime to check; pass null to use current date</param>
        /// <returns>Result</returns>
        bool ContactIsAvailable(Contact contact, DateTime? dateTime = null);

        #endregion

    }
}

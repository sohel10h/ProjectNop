using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Domain.Contacts;
using Nop.Web.Areas.Admin.Models.Contact;

namespace Nop.Web.Factories
{
    /// <summary>
    /// Contact service interface
    /// </summary>
    public partial interface IContactModelFactory
    {
        /// <summary>
        /// Prepare blog post model
        /// </summary>
        /// <param name="model">Contact post model</param>
        /// <param name="blogPost">Contact post entity</param>
        /// <param name="prepareComments">Whether to prepare blog comments</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task PrepareContactModelAsync(ContactModel model, Contact blogPost, bool prepareComments);

        /// <summary>
        /// Prepare blog post list model
        /// </summary>
        /// <param name="command">Contact paging filtering model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the blog post list model
        /// </returns>
        Task<ContactListModel> PrepareContactListModelAsync();
    }
}

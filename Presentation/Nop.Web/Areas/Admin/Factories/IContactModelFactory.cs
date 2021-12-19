using System.Threading.Tasks;
using Nop.Core.Domain.Contacts;
using Nop.Web.Areas.Admin.Models.Contact;

namespace Nop.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the Contact model factory
    /// </summary>
    public partial interface IContactModelFactory
    {
        /// <summary>
        /// Prepare Contact search model
        /// </summary>
        /// <param name="searchModel">Contact search model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic search model
        /// </returns>
        Task<ContactSearchModel> PrepareContactSearchModelAsync(ContactSearchModel searchModel);

        /// <summary>
        /// Prepare paged Contact list model
        /// </summary>
        /// <param name="searchModel">Contact search model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic list model
        /// </returns>
        Task<ContactListModel> PrepareContactListModelAsync(ContactSearchModel searchModel,int type = 2);

        /// <summary>
        /// Prepare Contact model
        /// </summary>
        /// <param name="model">Contact model</param>
        /// <param name="Contact">Contact</param>
        /// <param name="excludeProperties">Whether to exclude populating of some properties of model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the opic model
        /// </returns>
        Task<ContactModel> PrepareContactModelAsync(ContactModel model, Contact Contact, bool excludeProperties = false);
    }
}
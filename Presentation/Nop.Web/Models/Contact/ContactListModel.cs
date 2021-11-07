using Nop.Web.Framework.Models;
using System.Collections.Generic;

namespace Nop.Web.Models.Contact
{
    /// <summary>
    /// Represents a blog comment list model
    /// </summary>
    public partial record ContactListModel : BaseNopEntityModel
    {
        public ContactListModel()
        {
            //PagingFilteringContext = new ContactListModelModel();
            Contacts = new List<ContactListModel>();
        }

        public int WorkingLanguageId { get; set; }
        //public ContactListModelFilteringModel PagingFilteringContext { get; set; }
        public IList<ContactListModel> Contacts { get; set; }
    }
}
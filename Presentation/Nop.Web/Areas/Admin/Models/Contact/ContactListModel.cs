using Nop.Web.Framework.Models;
using System.Collections.Generic;

namespace Nop.Web.Areas.Admin.Models.Contact
{
    /// <summary>
    /// Represents a blog comment list model
    /// </summary>
    public partial record ContactListModel : BaseNopModel
    {
        public ContactListModel()
        {
            Contacts = new List<ContactModel>();
        }

        public int WorkingLanguageId { get; set; }
        public IList<ContactModel> Contacts { get; set; }
    }
}
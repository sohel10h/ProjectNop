using Nop.Web.Framework.Models;
using Nop.Web.Models.Contact;
using System.Collections.Generic;

namespace Nop.Web.Areas.Admin.Models.Contact
{
    /// <summary>
    /// Represents a blog comment list model
    /// </summary>
    public partial record ContactListModel : BasePagedListModel<ContactModel>
    {
    }
}
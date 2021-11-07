using Nop.Web.Framework.Models;

namespace Nop.Web.Areas.Admin.Models.Contact
{
    /// <summary>
    /// Represents a blog comment list model
    /// </summary>
    public partial record ContactListModel : BasePagedListModel<ContactModel>
    {
    }
}
using Nop.Web.Framework.Models;
using System.Collections.Generic;

namespace Nop.Web.Models.SallerItem
{
    public partial record SallerItemListModel : BaseNopModel
    {
        public SallerItemListModel()
        {
            //PagingFilteringContext = new ContactListModelModel();
            SallerItemList = new List<SallerItemListModel>();
        }

        public int WorkingLanguageId { get; set; }
        //public ContactListModelFilteringModel PagingFilteringContext { get; set; }
        public IList<SallerItemListModel> SallerItemList { get; set; }
    }
}

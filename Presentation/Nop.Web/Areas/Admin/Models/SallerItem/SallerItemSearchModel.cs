using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Areas.Admin.Models.Contact
{
    public partial record SallerItemSearchModel : BaseSearchModel
    {

        public SallerItemSearchModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Admin.SallerItemSearch.List.SearchStore")]
        public int SearchStoreId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        [NopResourceDisplayName("Admin.SallerItemSearch.List.SearchKeywords")]
        public string SearchKeywords { get; set; }

        public bool HideStoresList { get; set; }
    }
}

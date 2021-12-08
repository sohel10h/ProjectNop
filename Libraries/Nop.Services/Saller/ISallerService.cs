using Nop.Core;
using Nop.Core.Domain.SallerItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.Saller
{
    public interface ISallerService
    {
         Task SaveSallerItem(SallerItem item);
         Task<List<SallerItem>> GetCustomerSallerItems(int id);
        Task<IList<SallerItem>> GetAllSallerItemsListAsync();
        Task<IPagedList<SallerItem>> GetAllSallerItemsAsync(int type = 0, int pageIndex = 0, int pageSize = int.MaxValue);
    }
}

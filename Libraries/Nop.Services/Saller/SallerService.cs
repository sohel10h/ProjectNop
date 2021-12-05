using Nop.Core.Domain.SallerItems;
using Nop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.Saller
{
    public class SallerService : ISallerService
    {
        private readonly IRepository<SallerItem> _sallerRepository;

        public SallerService(IRepository<SallerItem> sallerRepository) 
        {
            this._sallerRepository = sallerRepository;
        
        }

        public async Task SaveSallerItem(SallerItem item)
        {
            await _sallerRepository.InsertAsync(item);
        }

        public async Task<List<SallerItem>> GetCustomerSallerItems(int id)
        {
            var itms = await _sallerRepository.Table.Where(c => c.CustomerId == id).ToListAsync();
            return itms;
        }

    }
}

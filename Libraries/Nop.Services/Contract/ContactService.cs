using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Domain.Contacts;
using Nop.Data;
using Nop.Services.Stores;

namespace Nop.Services.Contacts
{
    /// <summary>
    /// Contact service
    /// </summary>
    public partial class ContactService : IContactService
    {
        #region Fields

        private readonly IRepository<Contact> _contactRepository;
        private readonly IStaticCacheManager _staticCacheManager;
        private readonly IStoreMappingService _storeMappingService;

        #endregion

        #region Ctor

        public ContactService(
            IRepository<Contact> contactRepository,
            IStaticCacheManager staticCacheManager,
            IStoreMappingService storeMappingService)
        {
            _contactRepository = contactRepository;
            _staticCacheManager = staticCacheManager;
            _storeMappingService = storeMappingService;
        }

        #endregion

        public bool ContactIsAvailable(Contact contact, DateTime? dateTime = null)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public async Task<IPagedList<Contact>> GetAllContactsAsync(int pageIndex = 0, int pageSize = int.MaxValue)
        {
            return await _contactRepository.GetAllPagedAsync(async query => {return query;}, pageIndex, pageSize);
        }

        //public async Task<IList<Contact>> GetAllContactsAsync(int pageIndex = 0, int pageSize = int.MaxValue)
        //{
        //    //return await _contactRepository.GetAllPagedAsync(async query => {return query;}, pageIndex, pageSize);
        //    return await _contactRepository.GetAllAsync(query =>
        //    {
        //        return from p in query
        //               where
        //                     !p.Deleted
        //               select p;
        //    });
        //}


        public Task<Contact> GetContactByIdAsync(int contactId)
        {
            throw new NotImplementedException();
        }

        public Task InsertContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task UpdateContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
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

        public async Task DeleteContactAsync(Contact contact)
        {
            contact.Deleted = true;
            await _contactRepository.UpdateAsync(contact);
        }

        public async Task<IPagedList<Contact>> GetAllContactsAsync(int type = 0,int pageIndex = 0, int pageSize = int.MaxValue)
        {
            return await _contactRepository.GetAllPagedAsync(async query => { return query.Where(c => c.Type.Equals(type) && c.Deleted==false).OrderByDescending(o => o.CreatedOnUtc); }, pageIndex, pageSize);    
        }

        public async Task<IPagedList<Contact>> GetAllContactsAsync(int customerId, int type = 0, int pageIndex = 0, int pageSize = int.MaxValue)
        {
            return await _contactRepository.GetAllPagedAsync(async query => { return query.Where(c => c.Type==type && c.Deleted == false && c.CustomerId==customerId).OrderByDescending(o => o.CreatedOnUtc); }, pageIndex, pageSize);
        }


        //public virtual async Task<IList<Contact>> GetAllContactsAsync(int type = 0, int pageIndex = 0, int pageSize = int.MaxValue)
        //{
        //    var contact = await _contactRepository.GetAllAsync();

        //    return contact;
        //}

        public async Task<IList<Contact>> GetAllContactsListAsync()
        {
            return await _contactRepository.GetAllAsync(
                async query => { 
                    return query; 
                });
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


        public async Task<Contact> GetContactByIdAsync(int contactId)
        {
            return await _contactRepository.GetByIdAsync(contactId);
        }



        public virtual async Task InsertContactAsync(Contact contact)
        {
            contact.CreatedOnUtc= DateTime.Now;
            await _contactRepository.InsertAsync(contact);
        }

        public virtual async Task<Contact> UpdateContactAsync(Contact contact)
        {
           await _contactRepository.UpdateAsync(contact);
           return contact;
        }
    }
}
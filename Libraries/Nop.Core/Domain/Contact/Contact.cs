using System;
using Nop.Core.Domain.Common;

namespace Nop.Core.Domain.Contacts
{
    /// <summary>
    /// Represents a Contact
    /// </summary>
    public partial class Contact : BaseEntity, ISoftDeletedEntity
    {
        public string Name { get; set; }
        public bool Deleted { get; set; }
        public string Address { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int ID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int Type { get; set; }
        public int StoreId { get; set; }
        public DateTime VisitDate { get; set; }
        public int Status { get; set; }
    }
}
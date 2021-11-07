using FluentMigrator.Builders.Create.Table;
using Nop.Core.Domain.Blogs;
using Nop.Core.Domain.Contacts;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Stores;
using Nop.Data.Extensions;

namespace Nop.Data.Mapping.Builders.Blogs
{
    /// <summary>
    /// Represents a Contact comment entity builder
    /// </summary>
    public partial class ContactBuilder : NopEntityBuilder<Contact>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(Contact.StoreId)).AsInt32().ForeignKey<Contact>();
        }

        #endregion
    }
}
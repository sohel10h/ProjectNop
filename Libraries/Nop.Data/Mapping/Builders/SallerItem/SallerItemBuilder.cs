using FluentMigrator.Builders.Create.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.SallerItems;

namespace Nop.Data.Mapping.Builders.SallerItems
{
    /// <summary>
    /// Represents a Contact comment entity builder
    /// </summary>
    public partial class SallerItemBuilder : NopEntityBuilder<SallerItem>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {

            table.WithColumn(nameof(SallerItem.ProductName)).AsString(1000).NotNullable();
            table.WithColumn(nameof(SallerItem.ImageString)).AsString(1000).Nullable();
            table.WithColumn(nameof(SallerItem.ProductDescription)).AsString().Nullable();
        }

        #endregion
    }
}

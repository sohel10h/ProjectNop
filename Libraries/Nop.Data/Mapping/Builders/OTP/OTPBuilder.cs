using FluentMigrator.Builders.Create.Table;
using Nop.Core.Domain.OTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Data.Mapping.Builders.OTP
{
    public class OTPBuilder : NopEntityBuilder<OTPInfo>
    {
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            //table
            //   .WithColumn(nameof(OTPInfo.StoreId)).AsInt32().ForeignKey<OTPInfo>();
        }
    }
}

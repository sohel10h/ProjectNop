using Nop.Core.Domain.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.OTP
{
    public class OTPInfo : BaseEntity
    {
        public int CustomerId { get; set; }
        public string OTPString { get; set; }
        public string MobileNumber { get; set; }
        public DateTime CreateOn { get; set; }
        //public bool LimitedToStores { get; set; }
        //public int StoreId { get; set; }

    }
}

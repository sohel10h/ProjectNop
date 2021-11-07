using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Customers
{
    public enum CustomerStatus
    {

        Customer = 0,

        /// <summary>
        /// Processing
        /// </summary>
        RequestedForSaler = 10,

        /// <summary>
        /// Complete
        /// </summary>
        RequestedForSalerApproved = 20,

        /// <summary>
        /// Cancelled
        /// </summary>


    }
}

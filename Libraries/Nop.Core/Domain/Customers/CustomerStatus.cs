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
        RequestedForCareer= 10,
        /// <summary>
        /// Complete
        /// </summary>
        RequestedForCareerApproved = 20,

        RequestedForSaller= 30,

        RequestedForSallerApproved = 40,

        /// <summary>
        /// Cancelled
        /// </summary>


    }
}

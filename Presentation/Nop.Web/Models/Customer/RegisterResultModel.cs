using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Customer
{
    public partial record RegisterResultModel : BaseNopModel
    {
        public string Result { get; set; }
        public string ReturnUrl { get; set; }
        public string MobileNumber { get; set; }
        public string OtpString { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Customer
{
    public partial record PasswordRecoveryModel : BaseNopModel
    {
        //[DataType(DataType.EmailAddress)]
        [NopResourceDisplayName("Account.PasswordRecovery.Mobile")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string OTP { get; set; }
        public string Result { get; set; }
        public bool DisplayCaptcha { get; set; }
    }
}
using Nop.Core.Domain.OTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.OTP
{
    public interface IOTPService
    {
        Task InsertOTP(OTPInfo otp);
        Task<OTPInfo> GetOtp(int customerId, string mobileNumber);
        Task<OTPInfo> GetOtp(int customerId, string mobileNumber, string otpString);
        Task<OTPInfo> CreateAndSendOtp(OTPInfo otp);
    }
}

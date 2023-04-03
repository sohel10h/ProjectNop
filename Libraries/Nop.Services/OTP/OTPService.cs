using Nop.Core.Domain.OTP;
using Nop.Data;
using Nop.Services.Localization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.OTP
{
    public class OTPService: IOTPService
    {
        private readonly IRepository<OTPInfo> _otpRepository;
        private readonly ILocalizationService _localizationService;

        public OTPService(IRepository<OTPInfo> otpRepository, ILocalizationService localizationService) 
        {
            _otpRepository = otpRepository;
            _localizationService = localizationService;
        }


        public async Task InsertOTP(OTPInfo otp) 
        {
           await _otpRepository.InsertAsync(otp);
        }

        public async Task<OTPInfo> GetOtp(int customerId, string mobileNumber)
        {
            var otp=await _otpRepository.Table.Where(o => o.CustomerId == customerId && o.MobileNumber == mobileNumber).FirstOrDefaultAsync();
            return otp;
        }


        public async Task<OTPInfo> CreateAndSendOtp(OTPInfo otp,bool isForgetPassword=false)
        {
            await InsertOTP(otp);
            await SendSMS(otp);
            return otp;
        }

        public async Task<OTPInfo> GetOtp(int customerId, string mobileNumber,string otpString)
        {
            var otp = await _otpRepository.Table.Where(o => o.CustomerId == customerId && o.MobileNumber == mobileNumber && o.OTPString== otpString).FirstOrDefaultAsync();
            return otp;
        }


        public async  Task SendSMS(OTPInfo otp, bool isForgetPassword = false)
        {
            string result = "";
            WebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                //string userid = "canviador";
                //string password = "CSHWZBGR";
                string number = otp.MobileNumber;
                string message = string.Empty;
                try 
                {
                    string resource = string.Empty;
                    if (isForgetPassword)
                    {
                        resource = await _localizationService.GetResourceAsync("OTP.Message");
                    }
                    else 
                    {
                        resource = await _localizationService.GetResourceAsync("OTP.Forget.Password.Message");
                    }
                    message= String.Format(resource, otp.OTPString);
                }
                catch 
                {
                    message = "Your OTP is: " + otp.OTPString;
                }
                message = System.Uri.EscapeUriString(message);
                //String url = "http://66.45.237.70/api.php?username=" + userid + "&password=" + password + "&number=" + number + "&message=" + message;
                string url = "http://bulksmsbd.net/api/smsapi?api_key=ZEu4oCoiSOtR0ySk4qkD&type=text&number="+ number + "&senderid=Canviador&message="+ message;
                request = WebRequest.Create(url);






                // Send the 'HttpWebRequest' and wait for response.
                response =  (HttpWebResponse) (await request.GetResponseAsync());
                Stream stream = response.GetResponseStream();
                Encoding ec = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader reader = new
                System.IO.StreamReader(stream, ec);
                result = reader.ReadToEnd();
                Console.WriteLine(result);
                reader.Close();
                stream.Close();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
            finally
            {
                if (response != null)
                    response.Close();
            }
        }





    }
}

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


        public async Task<OTPInfo> CreateAndSendOtp(OTPInfo otp)
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


        public async  Task SendSMS(OTPInfo otp)
        {
            string result = "";
            WebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                String userid = "canviador"; //Your Login ID
                String password = "CSHWZBGR"; //Your Password
                String number = otp.MobileNumber; //Recipient Phone Number multiple number must be separated by comma
                String message = System.Uri.EscapeUriString("ALLAH IS ONE"); //do not use single quotation (') in the message to avoid forbidden result
                String url = "http://66.45.237.70/api.php?username=" + userid + "&password=" + password + "&number=" + number + "&message=" + message;
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

﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Primitives;
using Nop.Core;
using Nop.Core.Domain;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Forums;
using Nop.Core.Domain.Gdpr;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Media;
using Nop.Core.Domain.Messages;
using Nop.Core.Domain.OTP;
using Nop.Core.Domain.Security;
using Nop.Core.Domain.Tax;
using Nop.Core.Events;
using Nop.Core.Http;
using Nop.Core.Http.Extensions;
using Nop.Services.Authentication;
using Nop.Services.Authentication.External;
using Nop.Services.Authentication.MultiFactor;
using Nop.Services.Catalog;
using Nop.Services.Common;
using Nop.Services.Customers;
using Nop.Services.Directory;
using Nop.Services.ExportImport;
using Nop.Services.Gdpr;
using Nop.Services.Helpers;
using Nop.Services.Localization;
using Nop.Services.Logging;
using Nop.Services.Media;
using Nop.Services.Messages;
using Nop.Services.Orders;
using Nop.Services.OTP;
using Nop.Services.Tax;
using Nop.Web.Extensions;
using Nop.Web.Factories;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using Nop.Web.Framework.Validators;
using Nop.Web.Models.Customer;


namespace Nop.Web.Controllers
{
    public class CustomController : BasePublicController
    {

        private readonly AddressSettings _addressSettings;
        private readonly CaptchaSettings _captchaSettings;
        private readonly CustomerSettings _customerSettings;
        private readonly DateTimeSettings _dateTimeSettings;
        private readonly IDownloadService _downloadService;
        private readonly ForumSettings _forumSettings;
        private readonly GdprSettings _gdprSettings;
        private readonly IAddressAttributeParser _addressAttributeParser;
        private readonly IAddressModelFactory _addressModelFactory;
        private readonly IAddressService _addressService;
        private readonly IAuthenticationService _authenticationService;
        private readonly ICountryService _countryService;
        private readonly ICurrencyService _currencyService;
        private readonly ICustomerActivityService _customerActivityService;
        private readonly ICustomerAttributeParser _customerAttributeParser;
        private readonly ICustomerAttributeService _customerAttributeService;
        private readonly ICustomerModelFactory _customerModelFactory;
        private readonly ICustomerRegistrationService _customerRegistrationService;
        private readonly ICustomerService _customerService;
        private readonly IEventPublisher _eventPublisher;
        private readonly IExportManager _exportManager;
        private readonly IExternalAuthenticationService _externalAuthenticationService;
        private readonly IGdprService _gdprService;
        private readonly IGenericAttributeService _genericAttributeService;
        private readonly IGiftCardService _giftCardService;
        private readonly ILocalizationService _localizationService;
        private readonly ILogger _logger;
        private readonly IMultiFactorAuthenticationPluginManager _multiFactorAuthenticationPluginManager;
        private readonly INewsLetterSubscriptionService _newsLetterSubscriptionService;
        private readonly INotificationService _notificationService;
        private readonly IOrderService _orderService;
        private readonly IPictureService _pictureService;
        private readonly IPriceFormatter _priceFormatter;
        private readonly IProductService _productService;
        private readonly IStateProvinceService _stateProvinceService;
        private readonly IStoreContext _storeContext;
        private readonly ITaxService _taxService;
        private readonly IWorkContext _workContext;
        private readonly IWorkflowMessageService _workflowMessageService;
        private readonly LocalizationSettings _localizationSettings;
        private readonly MediaSettings _mediaSettings;
        private readonly MultiFactorAuthenticationSettings _multiFactorAuthenticationSettings;
        private readonly StoreInformationSettings _storeInformationSettings;
        private readonly TaxSettings _taxSettings;
        private readonly IOTPService _otpService;
        private readonly IWebHelper _webHelper;




        public CustomController(AddressSettings addressSettings,
            CaptchaSettings captchaSettings,
            CustomerSettings customerSettings,
            DateTimeSettings dateTimeSettings,
            IDownloadService downloadService,
            ForumSettings forumSettings,
            GdprSettings gdprSettings,
            IAddressAttributeParser addressAttributeParser,
            IAddressModelFactory addressModelFactory,
            IAddressService addressService,
            IAuthenticationService authenticationService,
            ICountryService countryService,
            ICurrencyService currencyService,
            ICustomerActivityService customerActivityService,
            ICustomerAttributeParser customerAttributeParser,
            ICustomerAttributeService customerAttributeService,
            ICustomerModelFactory customerModelFactory,
            ICustomerRegistrationService customerRegistrationService,
            ICustomerService customerService,
            IEventPublisher eventPublisher,
            IExportManager exportManager,
            IExternalAuthenticationService externalAuthenticationService,
            IGdprService gdprService,
            IGenericAttributeService genericAttributeService,
            IGiftCardService giftCardService,
            ILocalizationService localizationService,
            ILogger logger,
            IMultiFactorAuthenticationPluginManager multiFactorAuthenticationPluginManager,
            INewsLetterSubscriptionService newsLetterSubscriptionService,
            INotificationService notificationService,
            IOrderService orderService,
            IPictureService pictureService,
            IPriceFormatter priceFormatter,
            IProductService productService,
            IStateProvinceService stateProvinceService,
            IStoreContext storeContext,
            ITaxService taxService,
            IWorkContext workContext,
            IWorkflowMessageService workflowMessageService,
            LocalizationSettings localizationSettings,
            MediaSettings mediaSettings,
            MultiFactorAuthenticationSettings multiFactorAuthenticationSettings,
            StoreInformationSettings storeInformationSettings,
            IOTPService otpService,
            IWebHelper webHelper,
            TaxSettings taxSettings) 
        {


            _addressSettings = addressSettings;
            _captchaSettings = captchaSettings;
            _customerSettings = customerSettings;
            _dateTimeSettings = dateTimeSettings;
            _downloadService = downloadService;
            _forumSettings = forumSettings;
            _gdprSettings = gdprSettings;
            _addressAttributeParser = addressAttributeParser;
            _addressModelFactory = addressModelFactory;
            _addressService = addressService;
            _authenticationService = authenticationService;
            _countryService = countryService;
            _currencyService = currencyService;
            _customerActivityService = customerActivityService;
            _customerAttributeParser = customerAttributeParser;
            _customerAttributeService = customerAttributeService;
            _customerModelFactory = customerModelFactory;
            _customerRegistrationService = customerRegistrationService;
            _customerService = customerService;
            _eventPublisher = eventPublisher;
            _exportManager = exportManager;
            _externalAuthenticationService = externalAuthenticationService;
            _gdprService = gdprService;
            _genericAttributeService = genericAttributeService;
            _giftCardService = giftCardService;
            _localizationService = localizationService;
            _logger = logger;
            _multiFactorAuthenticationPluginManager = multiFactorAuthenticationPluginManager;
            _newsLetterSubscriptionService = newsLetterSubscriptionService;
            _notificationService = notificationService;
            _orderService = orderService;
            _pictureService = pictureService;
            _priceFormatter = priceFormatter;
            _productService = productService;
            _stateProvinceService = stateProvinceService;
            _storeContext = storeContext;
            _taxService = taxService;
            _workContext = workContext;
            _workflowMessageService = workflowMessageService;
            _localizationSettings = localizationSettings;
            _mediaSettings = mediaSettings;
            _multiFactorAuthenticationSettings = multiFactorAuthenticationSettings;
            _storeInformationSettings = storeInformationSettings;
            _taxSettings = taxSettings;
            _otpService = otpService;
            _webHelper = webHelper;
        }



        [HttpPost]
        public virtual async Task<IActionResult> MobileLogin(string username, string password)
        {
            var model = new MobileLogin();
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var loginResult = await _customerRegistrationService.ValidateCustomerAsync(username, password);
                switch (loginResult)
                {
                    case CustomerLoginResults.Successful:
                        {
                            model.Result = true;
                            model.Customer = _customerSettings.UsernamesEnabled
                                ? await _customerService.GetCustomerByUsernameAsync(username)
                                : await _customerService.GetCustomerByEmailAsync(username);
                            return Json(model);
                        }
                    case CustomerLoginResults.CustomerNotExist:
                        model.Result = false;
                        model.ErrorResult = await _localizationService.GetResourceAsync("Account.Login.WrongCredentials.CustomerNotExist");
                        break;
                    case CustomerLoginResults.Deleted:
                        model.Result = false;
                        model.ErrorResult = await _localizationService.GetResourceAsync("Account.Login.WrongCredentials.Deleted");
                        break;
                    case CustomerLoginResults.NotActive:
                        model.Result = false;
                        model.ErrorResult = await _localizationService.GetResourceAsync("Account.Login.WrongCredentials.NotActive");
                        break;
                    case CustomerLoginResults.NotRegistered:
                        model.Result = false;
                        model.ErrorResult = await _localizationService.GetResourceAsync("Account.Login.WrongCredentials.NotRegistered");
                        break;
                    case CustomerLoginResults.LockedOut:
                        model.Result = false;
                        model.ErrorResult = await _localizationService.GetResourceAsync("Account.Login.WrongCredentials.LockedOut");
                        break;
                    case CustomerLoginResults.WrongPassword:
                    default:
                        model.Result = false;
                        model.ErrorResult = await _localizationService.GetResourceAsync("Account.Login.WrongCredentials");
                        break;
                }
            }
            else 
            {
                model.Result = false;
                model.ErrorResult = "Mobile number or Password can not be null";
            }
            return Json(model);
        }


        [HttpPost]
        public virtual async Task<IActionResult> ConfirmPassword(string username, string password, string OtpString)
        {
            var model = new MobileLogin();
            if (string.IsNullOrWhiteSpace(username))
            {
                model.Result = false;
                model.ErrorResult = "Phone number is required";
                return Json(model);
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                model.Result = false;
                model.ErrorResult = "ConfirmPassword is required";
                return Json(model);
            }

            var customer = await _customerService.GetCustomerByUsernameAsync(username);
            var otpresult = await _otpService.GetOtp(customer.Id, username, OtpString);
            if (otpresult != null && customer != null)
            {
                if (!customer.Active)
                {
                    customer.Active = true;
                    await _customerService.UpdateCustomerAsync(customer);
                }
                var request = new ChangePasswordRequest(customer.Username,
                                    false, _customerSettings.DefaultPasswordFormat, password,useUserName:true);
                var response = await _customerRegistrationService.ChangePasswordAsync(request);
                if (!response.Success)
                {
                    model.Result = false;
                    model.ErrorResult = string.Join(';', response.Errors);
                    return Json(model);
                }
                model.Result = true;
                model.Customer = _customerSettings.UsernamesEnabled
                    ? await _customerService.GetCustomerByUsernameAsync(username)
                    : await _customerService.GetCustomerByEmailAsync(username);
                return Json(model);
            }
            else
            {
                if (customer == null)
                {
                    model.Result = false;
                    model.ErrorResult = await _localizationService.GetResourceAsync("Account.Login.WrongCredentials.CustomerNotExist");
                    return Json(model);
                } 
                else
                {
                    model.Result = false;
                    model.ErrorResult = "OTP not matched";
                    return Json(model);
                }
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> PasswordRecoverySend(string username)
        {
            var retn = new MobileLogin();

            if (string.IsNullOrWhiteSpace(username))
            {
                retn.Result = false;
                retn.ErrorResult= "Phone number is required";
                return Json(retn);

            }            
            var customer = await _customerService.GetCustomerByUsernameAsync(username.Trim());
            if (customer != null && customer.Active && !customer.Deleted)
            {
                //save token and current date
                var passwordRecoveryToken = Guid.NewGuid();
                await _genericAttributeService.SaveAttributeAsync(customer, NopCustomerDefaults.PasswordRecoveryTokenAttribute,
                    passwordRecoveryToken.ToString());
                DateTime? generatedDateTime = DateTime.UtcNow;
                await _genericAttributeService.SaveAttributeAsync(customer,
                    NopCustomerDefaults.PasswordRecoveryTokenDateGeneratedAttribute, generatedDateTime);

                Random generator = new Random();
                String r = generator.Next(0, 1000000).ToString("D6");
                var otp = new OTPInfo();
                otp.CustomerId = customer.Id;
                otp.MobileNumber = customer.Username;
                otp.CreateOn = DateTime.Now;
                otp.OTPString = r;
                await _otpService.CreateAndSendOtp(otp, true);
                retn.Result = true;
                return Json(retn);
            }   
            else
            {
                retn.Result = false;
                retn.ErrorResult= await _localizationService.GetResourceAsync("Account.PasswordRecovery.EmailNotFound");
                return Json(retn);
            }
           
        }


        //[HttpPost]
        //public virtual async Task<IActionResult> Register(RegisterModel model, IFormCollection form)
        //{
        //    //check whether registration is allowed
        //    if (_customerSettings.UserRegistrationType == UserRegistrationType.Disabled)
        //        return Json("");



        //    var customer =await _workContext.GetCurrentCustomerAsync();

        //    if (!string.IsNullOrWhiteSpace(model.Username) && !string.IsNullOrWhiteSpace(model.Password))
        //    {
        //        var customerUserName = model.Username?.Trim();
        //        var customerEmail = model.Email?.Trim();

        //        //var isApproved = _customerSettings.UserRegistrationType == UserRegistrationType.Standard;
        //        var isApproved = false;
        //        var registrationRequest = new CustomerRegistrationRequest(customer,
        //            customerEmail,
        //            customerUserName,
        //            model.Password,
        //            _customerSettings.DefaultPasswordFormat,
        //            (await _storeContext.GetCurrentStoreAsync()).Id,
        //            isApproved);
        //        var registrationResult = await _customerRegistrationService.RegisterCustomerAsync(registrationRequest);
        //        if (registrationResult.Success)
        //        {
                   
        //            if (_customerSettings.GenderEnabled)
        //                await _genericAttributeService.SaveAttributeAsync(customer, NopCustomerDefaults.GenderAttribute, model.Gender);
        //            if (_customerSettings.FirstNameEnabled)
        //                await _genericAttributeService.SaveAttributeAsync(customer, NopCustomerDefaults.FirstNameAttribute, model.FirstName);
        //            if (_customerSettings.LastNameEnabled)
        //                await _genericAttributeService.SaveAttributeAsync(customer, NopCustomerDefaults.LastNameAttribute, model.LastName);
                    
        //            if (_customerSettings.PhoneEnabled)
        //                await _genericAttributeService.SaveAttributeAsync(customer, NopCustomerDefaults.PhoneAttribute, model.Username);
                    

        //            //insert default address (if possible)
        //            var defaultAddress = new Address
        //            {
        //                FirstName = await _genericAttributeService.GetAttributeAsync<string>(customer, NopCustomerDefaults.FirstNameAttribute),
        //                LastName = await _genericAttributeService.GetAttributeAsync<string>(customer, NopCustomerDefaults.LastNameAttribute),
        //                Email = customer.Email,
        //                Company = await _genericAttributeService.GetAttributeAsync<string>(customer, NopCustomerDefaults.CompanyAttribute),
        //                CountryId = await _genericAttributeService.GetAttributeAsync<int>(customer, NopCustomerDefaults.CountryIdAttribute) > 0
        //                    ? (int?)await _genericAttributeService.GetAttributeAsync<int>(customer, NopCustomerDefaults.CountryIdAttribute)
        //                    : null,
        //                StateProvinceId = await _genericAttributeService.GetAttributeAsync<int>(customer, NopCustomerDefaults.StateProvinceIdAttribute) > 0
        //                    ? (int?)await _genericAttributeService.GetAttributeAsync<int>(customer, NopCustomerDefaults.StateProvinceIdAttribute)
        //                    : null,
        //                County = await _genericAttributeService.GetAttributeAsync<string>(customer, NopCustomerDefaults.CountyAttribute),
        //                City = await _genericAttributeService.GetAttributeAsync<string>(customer, NopCustomerDefaults.CityAttribute),
        //                Address1 = await _genericAttributeService.GetAttributeAsync<string>(customer, NopCustomerDefaults.StreetAddressAttribute),
        //                Address2 = await _genericAttributeService.GetAttributeAsync<string>(customer, NopCustomerDefaults.StreetAddress2Attribute),
        //                ZipPostalCode = await _genericAttributeService.GetAttributeAsync<string>(customer, NopCustomerDefaults.ZipPostalCodeAttribute),
        //                PhoneNumber = await _genericAttributeService.GetAttributeAsync<string>(customer, NopCustomerDefaults.PhoneAttribute),
        //                //FaxNumber = await _genericAttributeService.GetAttributeAsync<string>(customer, NopCustomerDefaults.FaxAttribute),
        //                CreatedOnUtc = customer.CreatedOnUtc
        //            };
        //            if (await _addressService.IsAddressValidAsync(defaultAddress))
        //            {
        //                //some validation
        //                if (defaultAddress.CountryId == 0)
        //                    defaultAddress.CountryId = null;
        //                if (defaultAddress.StateProvinceId == 0)
        //                    defaultAddress.StateProvinceId = null;
        //                //set default address
        //                //customer.Addresses.Add(defaultAddress);

        //                await _addressService.InsertAddressAsync(defaultAddress);

        //                await _customerService.InsertCustomerAddressAsync(customer, defaultAddress);

        //                customer.BillingAddressId = defaultAddress.Id;
        //                customer.ShippingAddressId = defaultAddress.Id;

        //                await _customerService.UpdateCustomerAsync(customer);
        //            }

        //            //notifications
        //            if (_customerSettings.NotifyNewCustomerRegistration)
        //                await _workflowMessageService.SendCustomerRegisteredNotificationMessageAsync(customer,
        //                    _localizationSettings.DefaultAdminLanguageId);

        //            //raise event       
        //            await _eventPublisher.PublishAsync(new CustomerRegisteredEvent(customer));

        //            switch (_customerSettings.UserRegistrationType)
        //            {
        //                case UserRegistrationType.EmailValidation:
        //                    //email validation message
        //                    await _genericAttributeService.SaveAttributeAsync(customer, NopCustomerDefaults.AccountActivationTokenAttribute, Guid.NewGuid().ToString());
        //                    await _workflowMessageService.SendCustomerEmailValidationMessageAsync(customer, (await _workContext.GetWorkingLanguageAsync()).Id);

        //                    //result
        //                    return RedirectToRoute("RegisterResult", new { resultId = (int)UserRegistrationType.EmailValidation, returnUrl });

        //                case UserRegistrationType.AdminApproval:
        //                    return RedirectToRoute("RegisterResult", new { resultId = (int)UserRegistrationType.AdminApproval, returnUrl });

        //                case UserRegistrationType.Standard:
        //                    //send customer welcome message
        //                    Random generator = new Random();
        //                    String r = generator.Next(0, 1000000).ToString("D6");
        //                    var otp = new OTPInfo();
        //                    otp.CustomerId = customer.Id;
        //                    otp.MobileNumber = customer.Username;
        //                    otp.CreateOn = DateTime.Now;
        //                    otp.OTPString = r;
        //                    await _otpService.CreateAndSendOtp(otp);

        //                    //await _workflowMessageService.SendCustomerWelcomeMessageAsync(customer, (await _workContext.GetWorkingLanguageAsync()).Id);

        //                    //raise event       
        //                    await _eventPublisher.PublishAsync(new CustomerActivatedEvent(customer));

        //                    //returnUrl = Url.RouteUrl("RegisterResult", new { resultId = (int)UserRegistrationType.Standard, returnUrl, otp.MobileNumber });
        //                    //return await _customerRegistrationService.SignInCustomerAsync(customer, returnUrl, true);

        //                    return RedirectToAction("RegisterResult", new { resultId = (int)UserRegistrationType.Standard, returnUrl, otp.MobileNumber });

        //                default:
        //                    return RedirectToRoute("Homepage");
        //            }
        //        }

        //        //errors
        //        foreach (var error in registrationResult.Errors)
        //            ModelState.AddModelError("", error);
        //    }

        //    //If we got this far, something failed, redisplay form
        //    model = await _customerModelFactory.PrepareRegisterModelAsync(model, true, customerAttributesXml);

        //    return View(model);
        //}

    }
}
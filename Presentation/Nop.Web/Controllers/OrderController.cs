using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Orders;
using Nop.Services.Common;
using Nop.Services.Customers;
using Nop.Services.Media;
using Nop.Services.Orders;
using Nop.Services.Payments;
using Nop.Services.Shipping;
using Nop.Web.Factories;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using Nop.Web.Models.Order;

namespace Nop.Web.Controllers
{
    public partial class OrderController : BasePublicController
    {
        #region Fields

        private readonly ICustomerService _customerService;
        private readonly IOrderModelFactory _orderModelFactory;
        private readonly IOrderProcessingService _orderProcessingService;
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;
        private readonly IPdfService _pdfService;
        private readonly IShipmentService _shipmentService;
        private readonly IWebHelper _webHelper;
        private readonly IWorkContext _workContext;
        private readonly RewardPointsSettings _rewardPointsSettings;
        private readonly IPictureService _pictureService;
        #endregion

        #region Ctor

        public OrderController(ICustomerService customerService,
            IOrderModelFactory orderModelFactory,
            IOrderProcessingService orderProcessingService, 
            IOrderService orderService, 
            IPaymentService paymentService, 
            IPdfService pdfService,
            IShipmentService shipmentService, 
            IWebHelper webHelper,
            IWorkContext workContext,
            IPictureService pictureService,
            RewardPointsSettings rewardPointsSettings)
        {
            _customerService = customerService;
            _orderModelFactory = orderModelFactory;
            _orderProcessingService = orderProcessingService;
            _orderService = orderService;
            _paymentService = paymentService;
            _pdfService = pdfService;
            _shipmentService = shipmentService;
            _webHelper = webHelper;
            _workContext = workContext;
            _rewardPointsSettings = rewardPointsSettings;
            _pictureService = pictureService;
        }

        #endregion

        #region Methods

        //My account / Orders
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> CustomerOrders()
        {
            if (!await _customerService.IsRegisteredAsync(await _workContext.GetCurrentCustomerAsync()))
                return Challenge();

            var model = await _orderModelFactory.PrepareCustomerOrderListModelAsync();
            return View(model);
        }

        //My account / Orders / Cancel recurring order
        [HttpPost, ActionName("CustomerOrders")]
        [AutoValidateAntiforgeryToken]
        [FormValueRequired(FormValueRequirement.StartsWith, "cancelRecurringPayment")]
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> CancelRecurringPayment(IFormCollection form)
        {
            if (!await _customerService.IsRegisteredAsync(await _workContext.GetCurrentCustomerAsync()))
                return Challenge();

            //get recurring payment identifier
            var recurringPaymentId = 0;
            foreach (var formValue in form.Keys)
                if (formValue.StartsWith("cancelRecurringPayment", StringComparison.InvariantCultureIgnoreCase))
                    recurringPaymentId = Convert.ToInt32(formValue["cancelRecurringPayment".Length..]);

            var recurringPayment = await _orderService.GetRecurringPaymentByIdAsync(recurringPaymentId);
            if (recurringPayment == null)
            {
                return RedirectToRoute("CustomerOrders");
            }

            if (await _orderProcessingService.CanCancelRecurringPaymentAsync(await _workContext.GetCurrentCustomerAsync(), recurringPayment))
            {
                var errors = await _orderProcessingService.CancelRecurringPaymentAsync(recurringPayment);

                var model = await _orderModelFactory.PrepareCustomerOrderListModelAsync();
                model.RecurringPaymentErrors = errors;

                return View(model);
            }

            return RedirectToRoute("CustomerOrders");
        }

        //My account / Orders / Retry last recurring order
        [HttpPost, ActionName("CustomerOrders")]
        [AutoValidateAntiforgeryToken]
        [FormValueRequired(FormValueRequirement.StartsWith, "retryLastPayment")]
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> RetryLastRecurringPayment(IFormCollection form)
        {
            if (!await _customerService.IsRegisteredAsync(await _workContext.GetCurrentCustomerAsync()))
                return Challenge();

            //get recurring payment identifier
            var recurringPaymentId = 0;
            if (!form.Keys.Any(formValue => formValue.StartsWith("retryLastPayment", StringComparison.InvariantCultureIgnoreCase) &&
                int.TryParse(formValue[(formValue.IndexOf('_') + 1)..], out recurringPaymentId)))
            {
                return RedirectToRoute("CustomerOrders");
            }

            var recurringPayment = await _orderService.GetRecurringPaymentByIdAsync(recurringPaymentId);
            if (recurringPayment == null)
                return RedirectToRoute("CustomerOrders");

            if (!await _orderProcessingService.CanRetryLastRecurringPaymentAsync(await _workContext.GetCurrentCustomerAsync(), recurringPayment))
                return RedirectToRoute("CustomerOrders");

            var errors = await _orderProcessingService.ProcessNextRecurringPaymentAsync(recurringPayment);
            var model = await _orderModelFactory.PrepareCustomerOrderListModelAsync();
            model.RecurringPaymentErrors = errors.ToList();

            return View(model);
        }

        //My account / Reward points
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> CustomerRewardPoints(int? pageNumber)
        {
            if (!await _customerService.IsRegisteredAsync(await _workContext.GetCurrentCustomerAsync()))
                return Challenge();

            if (!_rewardPointsSettings.Enabled)
                return RedirectToRoute("CustomerInfo");

            var model = await _orderModelFactory.PrepareCustomerRewardPointsAsync(pageNumber);
            return View(model);
        }

        //My account / Order details page
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> Details(int orderId)
        {
            var order = await _orderService.GetOrderByIdAsync(orderId);
            if (order == null || order.Deleted || (await _workContext.GetCurrentCustomerAsync()).Id != order.CustomerId)
                return Challenge();

            var model = await _orderModelFactory.PrepareOrderDetailsModelAsync(order);
            return View(model);
        }

        //My account / Order details page / Print
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> PrintOrderDetails(int orderId)
        {
            var order = await _orderService.GetOrderByIdAsync(orderId);
            if (order == null || order.Deleted || (await _workContext.GetCurrentCustomerAsync()).Id != order.CustomerId)
                return Challenge();

            var model = await _orderModelFactory.PrepareOrderDetailsModelAsync(order);
            model.PrintMode = true;

            return View("Details", model);
        }

        //My account / Order details page / PDF invoice
        [CheckLanguageSeoCode(true)]
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> GetPdfInvoice(int orderId)
        {
            var order = await _orderService.GetOrderByIdAsync(orderId);
            if (order == null || order.Deleted || (await _workContext.GetCurrentCustomerAsync()).Id != order.CustomerId)
                return Challenge();

            var orders = new List<Order>();
            orders.Add(order);
            byte[] bytes;
            await using (var stream = new MemoryStream())
            {
                await _pdfService.PrintOrdersToPdfAsync(stream, orders, (await _workContext.GetWorkingLanguageAsync()).Id);
                bytes = stream.ToArray();
            }
            return File(bytes, MimeTypes.ApplicationPdf, $"order_{order.Id}.pdf");
        }

        //My account / Order details page / re-order
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> ReOrder(int orderId)
        {
            var order = await _orderService.GetOrderByIdAsync(orderId);
            if (order == null || order.Deleted || (await _workContext.GetCurrentCustomerAsync()).Id != order.CustomerId)
                return Challenge();

            await _orderProcessingService.ReOrderAsync(order);
            return RedirectToRoute("ShoppingCart");
        }

        //My account / Order details page / Complete payment
        [HttpPost, ActionName("Details")]
        [AutoValidateAntiforgeryToken]
        [FormValueRequired("repost-payment")]
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> RePostPayment(int orderId)
        {
            var order = await _orderService.GetOrderByIdAsync(orderId);
            if (order == null || order.Deleted || (await _workContext.GetCurrentCustomerAsync()).Id != order.CustomerId)
                return Challenge();

            if (!await _paymentService.CanRePostProcessPaymentAsync(order))
                return RedirectToRoute("OrderDetails", new { orderId = orderId });

            var postProcessPaymentRequest = new PostProcessPaymentRequest
            {
                Order = order
            };
            await _paymentService.PostProcessPaymentAsync(postProcessPaymentRequest);

            if (_webHelper.IsRequestBeingRedirected || _webHelper.IsPostBeingDone)
            {
                //redirection or POST has been done in PostProcessPayment
                return Content("Redirected");
            }

            //if no redirection has been done (to a third-party payment page)
            //theoretically it's not possible
            return RedirectToRoute("OrderDetails", new { orderId = orderId });
        }

        //My account / Order details page / Shipment details page
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> ShipmentDetails(int shipmentId)
        {
            var shipment = await _shipmentService.GetShipmentByIdAsync(shipmentId);
            if (shipment == null)
                return Challenge();

            var order = await _orderService.GetOrderByIdAsync(shipment.OrderId);
            
            if (order == null || order.Deleted || (await _workContext.GetCurrentCustomerAsync()).Id != order.CustomerId)
                return Challenge();

            var model = await _orderModelFactory.PrepareShipmentDetailsModelAsync(shipment);
            return View(model);
        }


        public virtual async Task<IActionResult> MakeAnOrder()
        {

            return View();
        }


        [HttpPost]
        public virtual async Task<IActionResult> MakeAnOrder(IFormCollection colletion)
        {
            var orders = new List<MakeAnOrder>();
            for (int i = 0; i <= 9; i++) 
            {
                var namekey = "name" + i;
                var name = colletion[namekey].ToString();
                if ( !string.IsNullOrEmpty(name)) 
                { 
                    var quantity = Convert.ToInt32(colletion["quantity" + i]);
                    var image = colletion.Files.GetFile("image"+i);
                    string fileName=string.Empty;
                    if (image != null) 
                    {
                        byte[] fileBytes;
                         fileName = Guid.NewGuid().ToString() + image.FileName;
                        using (var ms = new MemoryStream())
                        {
                            image.CopyTo(ms);
                            fileBytes = ms.ToArray();
                        }
                        await _pictureService.SaveMakeAnOrderThumbAsync(fileName, image.ContentType, fileBytes);
                    }
                    orders.Add(new Models.Order.MakeAnOrder
                    {
                        Id = Convert.ToInt32(colletion["id" + i]),
                        Name= name,
                        Quantity= quantity,
                        FileName= fileName
                    });
                }
            }

            string xmlString = null;
            XmlSerializer xmlSerializer = new XmlSerializer(orders.GetType());
            using (MemoryStream memoryStream = new MemoryStream())
            {
                xmlSerializer.Serialize(memoryStream, orders);
                memoryStream.Position = 0;
                xmlString = new StreamReader(memoryStream).ReadToEnd();
            }
            var customer = await _workContext.GetCurrentCustomerAsync();
            var order = new Order();
            var BillingAddressId = customer.BillingAddressId.HasValue ? customer.BillingAddressId.Value : 1;
            order.BillingAddressId = BillingAddressId;
            order.ShippingAddressId = BillingAddressId;
            order.ShippingStatus = Core.Domain.Shipping.ShippingStatus.NotYetShipped;
            order.PaymentStatus = Core.Domain.Payments.PaymentStatus.Pending;
            order.OrderStatus = OrderStatus.Pending;
            order.CustomerId = customer.Id;
            order.OrderGuid = Guid.NewGuid();
            order.CustomValuesXml = xmlString;
            order.CustomOrderNumber = "";
            await _orderService.InsertOrderAsync(order);
            return View();
        }



        #endregion
    }
}
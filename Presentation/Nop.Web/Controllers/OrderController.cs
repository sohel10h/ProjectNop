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
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.SallerItems;
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
using Nop.Services.Saller;
using Nop.Core.Domain.Tax;

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
        private readonly IAddressService _addressService;
        private readonly ShoppingCartSettings _shoppingCartSettings;
        private readonly ISallerService _sallerService;
        private readonly ICustomNumberFormatter _customNumberFormatter;


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
            IAddressService addressService,
            ShoppingCartSettings shoppingCartSettings,
            RewardPointsSettings rewardPointsSettings,
            ISallerService sallerService,
            ICustomNumberFormatter customNumberFormatter
            )
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
            _addressService = addressService;
            _shoppingCartSettings = shoppingCartSettings;
            _sallerService = sallerService;
            _customNumberFormatter = customNumberFormatter;
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

            var customer = await _workContext.GetCurrentCustomerAsync();

            var billingAddressId = customer.BillingAddressId;
            var shippingAddressId = customer.ShippingAddressId;

            if (billingAddressId.HasValue)
            {
                ViewBag.BillingAddress = await _addressService.GetAddressByIdAsync(billingAddressId.Value);
            }
            if (shippingAddressId.HasValue)
            {
                ViewBag.ShippingAddress = await _addressService.GetAddressByIdAsync(shippingAddressId.Value);
            }
            return View();
        }




        public virtual async Task<IActionResult> SalerPanel()
        {
            var customer = await _workContext.GetCurrentCustomerAsync();
            var oldItems =await _sallerService.GetCustomerSallerItems(customer.Id);
            return View(oldItems);
        }




        [HttpPost]
        public virtual async Task<IActionResult> MakeAnOrder(IFormCollection colletion)
        {
            List<MakeAnOrder> orders = await GetOrderInfos(colletion);
            var ordersJson = Newtonsoft.Json.JsonConvert.SerializeObject(orders);
            var shippingAddress = GetAddress(colletion, "Shipping");
            var billingAddress = GetAddress(colletion, "Billing");
            await _addressService.InsertAddressAsync(shippingAddress);
            await _addressService.InsertAddressAsync(billingAddress);


            var customer = await _workContext.GetCurrentCustomerAsync();
            var order = new Order();
            order.BillingAddressId = billingAddress.Id;
            order.ShippingAddressId = shippingAddress.Id;
            order.ShippingStatus = Core.Domain.Shipping.ShippingStatus.NotYetShipped;
            order.PaymentStatus = Core.Domain.Payments.PaymentStatus.Pending;
            order.OrderStatus = OrderStatus.Pending;
            order.CustomerId = customer.Id;
            order.OrderGuid = Guid.NewGuid();
            order.MakeAnOrderJson = ordersJson;
            order.CustomOrderNumber = "";
            var orderTotal = orders.Where(c => c.Id > 0).ToList().Sum(p => p.Price);
            order.OrderTotal = orderTotal;
            order.OrderSubtotalExclTax = orderTotal;
            order.OrderSubtotalInclTax = orderTotal;
            order.CreatedOnUtc = DateTime.Now;
            order.CurrencyRate = 1;
            await _orderService.InsertOrderAsync(order);
            order.CustomOrderNumber = _customNumberFormatter.GenerateOrderCustomNumber(order);
            await _orderService.UpdateOrderAsync(order);

            var ownProducts = orders.Where(c => c.Id > 0).ToList();
            if (ownProducts != null && ownProducts.Any())
            {
                foreach (var product in ownProducts)
                {
                    OrderItem itm = new OrderItem();
                    itm.OrderId = order.Id;
                    itm.PriceExclTax = product.Price * product.Quantity;
                    itm.PriceInclTax = product.Price * product.Quantity;
                    itm.UnitPriceInclTax = product.Price;
                    itm.UnitPriceExclTax = product.Price;
                    itm.Quantity = product.Quantity;
                    itm.ProductId = product.Id;
                    itm.AttributeDescription = product.AttrName;
                    await _orderService.InsertOrderItemAsync(itm);
                }
            }
            if (orders != null && orders.Any())
            {
                return Redirect("/orderdetails/" + order.Id);
            }
            return Redirect("/MakeAnOrder");
        }


        private Address GetAddress(IFormCollection colletion, string addressType)
        {
            var address = new Address();
            address.FirstName = colletion[addressType + "NewAddress.FirstName"].ToString();
            address.LastName = colletion[addressType + "NewAddress.LastName"].ToString();
            address.Email = colletion[addressType + "NewAddress.Email"].ToString();
            address.CountryId = Convert.ToInt16(colletion[addressType + "NewAddress.CountryId"]);
            address.City = colletion[addressType + "NewAddress.City"].ToString();
            address.Address1 = colletion[addressType + "NewAddress.Address1"].ToString();
            address.PhoneNumber = colletion[addressType + "NewAddress.PhoneNumber"].ToString();
            return address;
        }


        private async Task<List<MakeAnOrder>> GetOrderInfos(IFormCollection colletion,bool isCareer=false, int lineNumber=9)
        {
            var orders = new List<MakeAnOrder>();
            for (int i = 0; i <= lineNumber; i++)
            {
                var namekey = "name" + i;
                var name = colletion[namekey].ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    var quantity = Convert.ToInt32(colletion["quantity" + i]);
                    decimal price= decimal.Zero;
                    if (isCareer) 
                    {
                        price = Convert.ToDecimal(colletion["price" + i]);
                    }
                    var image = colletion.Files.GetFile("image" + i);
                    string fileName = string.Empty;
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
                        AttrName = colletion["attrName" + i].ToString(),
                        Name = name,
                        Quantity = quantity,
                        FileName = fileName,
                        Price = price,
                        Description = colletion["description"+i].ToString()
                    });
                }
            }
            return orders;
        }


        private async Task<List<SallerItem>> GetSallerItems(IFormCollection colletion,int customerId, bool isCareer = false, int lineNumber = 9)
        {
            var orders = new List<SallerItem>();
            for (int i = 0; i <= lineNumber; i++)
            {
                var namekey = "name" + i;
                var name = colletion[namekey].ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    var quantity = Convert.ToInt32(colletion["quantity" + i]);
                    var description = colletion["description" + i].ToString();

                    decimal price = decimal.Zero;
                    if (isCareer)
                    {
                        price = Convert.ToDecimal(colletion["price" + i]);
                    }

                    var image = colletion.Files.GetFile("image" + i);
                    string fileName = string.Empty;
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
                    orders.Add(new SallerItem
                    {
                        ProductName = name,
                        CustomerId = customerId,
                        ProductPrice = quantity,
                        ProductDescription= description,
                        ProductStatus=0,
                        ImageString= fileName
                    });
                }
            }
            return orders;
        }



        public virtual async Task<IActionResult> Tracking() 
        {
            if (!await _customerService.IsRegisteredAsync(await _workContext.GetCurrentCustomerAsync()))
                return Challenge();
            return View();
        }



        [HttpPost]
        public virtual async Task<IActionResult> Tracking(string trackingId)
        {
            if (!await _customerService.IsRegisteredAsync(await _workContext.GetCurrentCustomerAsync()))
                return Challenge();
            var orderId = 0;
            try 
            {
                orderId = Convert.ToInt32(trackingId);
            }
            catch 
            {
                ViewBag.TrackingException = true;
                return View();
            }
            var order= await _orderService.GetOrderByIdAsync(orderId);
            if (order != null)
            {
                return Redirect("/orderdetails/" + orderId);
            }
            else 
            {
                ViewBag.TrackingException = true;
                return View();
            }
        }


        public virtual async Task<IActionResult> SaleFromCareer()
        {
            if (!await _customerService.IsRegisteredAsync(await _workContext.GetCurrentCustomerAsync()))
                return Challenge();
            ViewBag.CarrerSelePdfLocation = _shoppingCartSettings.CarrerSelePdfLocation;
            var customer= await _workContext.GetCurrentCustomerAsync();
            var addresses=  await _customerService.GetAddressesByCustomerIdAsync(customer.Id);
            if (addresses.Any())
            {
                return View();
            }
            else 
            {
                TempData["AddressRequired"] = true;
                return Redirect("/customer/addressadd");
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> SaleFromCareer(IFormCollection colletion)
        {
            var lineNumber = Convert.ToInt16(colletion["lineItem"]);         
            List<MakeAnOrder> orders = await GetOrderInfos(colletion,true, lineNumber);
            var ordersJson = Newtonsoft.Json.JsonConvert.SerializeObject(orders.Where(o=>o.Id==0).ToList());
            
            var customer = await _workContext.GetCurrentCustomerAsync();
            var addresses = await _customerService.GetAddressesByCustomerIdAsync(customer.Id);

            if (!addresses.Any())
            {
                TempData["AddressRequired"] = true;
                return Redirect("/customer/addressadd");
            }

            var order = new Order();
            order.BillingAddressId = addresses[0].Id;
            order.ShippingAddressId = addresses[0].Id;
            order.ShippingStatus = Core.Domain.Shipping.ShippingStatus.NotYetShipped;
            order.PaymentStatus = Core.Domain.Payments.PaymentStatus.Pending;
            order.OrderStatus = OrderStatus.Pending;
            order.CustomerId = customer.Id;
            order.OrderGuid = Guid.NewGuid();
            order.MakeAnOrderJson = ordersJson;
            order.CustomOrderNumber = _customNumberFormatter.GenerateOrderCustomNumber(order);
            var orderTotal = orders.Where(c => c.Id > 0).ToList().Sum(p => p.Price);
            order.OrderTotal = orderTotal;
            order.OrderSubtotalExclTax = orderTotal;
            order.OrderSubtotalInclTax = orderTotal;
            order.CreatedOnUtc = DateTime.Now;
            order.CurrencyRate = 1;
            order.CustomerTaxDisplayType = TaxDisplayType.ExcludingTax;
            await _orderService.InsertOrderAsync(order);

            order.CustomOrderNumber = _customNumberFormatter.GenerateOrderCustomNumber(order);
            await _orderService.UpdateOrderAsync(order);


            var ownProducts = orders.Where(c => c.Id > 0).ToList();
            if (ownProducts != null && ownProducts.Any())
            {
                foreach (var product in ownProducts) 
                {
                    OrderItem itm = new OrderItem();
                    itm.OrderId = order.Id;
                    itm.PriceExclTax = product.Price* product.Quantity;                    
                    itm.PriceInclTax = product.Price * product.Quantity;
                    itm.UnitPriceInclTax = product.Price;
                    itm.UnitPriceExclTax = product.Price;
                    itm.Quantity = product.Quantity;
                    itm.ProductId = product.Id;
                    itm.AttributeDescription = product.AttrName;
                    await _orderService.InsertOrderItemAsync(itm);
                }
            }
            if (orders != null && orders.Any()) 
            {
                return Redirect("/orderdetails/"+ order.Id); 
            }
            return Redirect("/order/SaleFromCareer");
        }


        public virtual async Task<IActionResult> sallerRequest()
        {
            if (!await _customerService.IsRegisteredAsync(await _workContext.GetCurrentCustomerAsync()))
                return Challenge();
            return View();
        }

        [HttpPost]
        public virtual async Task<IActionResult> sallerRequest(IFormCollection colletion)
        {
            var lineNumber = Convert.ToInt16(colletion["lineItem"]);
            var customer = await _workContext.GetCurrentCustomerAsync();
            List<SallerItem> items = await GetSallerItems(colletion, customer.Id, true, lineNumber);
            foreach (var itm in items) 
            {
               await _sallerService.SaveSallerItem(itm);
            }
            return Redirect("/order/sallerRequest");
        }

        #endregion
    }
}
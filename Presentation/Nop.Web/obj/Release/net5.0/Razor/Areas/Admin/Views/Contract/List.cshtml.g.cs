#pragma checksum "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "433090704cf1b9144e9bfc91ed3d2b185ed61dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contract_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Contract/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 9 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.MultiFactorAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
using Nop.Web.Framework.Models.AdminAreaTour;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"433090704cf1b9144e9bfc91ed3d2b185ed61dd7", @"/Areas/Admin/Views/Contract/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181066c519b5e3a88fbfc1b430cb86e3463f4c97", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contract_List : Nop.Web.Framework.Mvc.Razor.NopRazorPage<TopicSearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopDocReferenceTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
  
    //page title
    ViewBag.PageTitle = T("Admin.ContentManagement.Topics").Text;
    //tour step
    ViewBag.TourStep = TourStep.TopicList;
    //active menu item (system name)
    Html.SetActiveMenuItemSystemName("Topics");

    string editQueryString = string.Empty;
    var showTour = ViewBag.ShowTour ?? false;
    if (showTour)
    {
        editQueryString = "?showtour=true";
    }

    const string hideSearchBlockAttributeName = "TopicsPage.HideSearchBlock";
    var hideSearchBlock = await genericAttributeService.GetAttributeAsync<bool>(await workContext.GetCurrentCustomerAsync(), hideSearchBlockAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
Write(await Html.PartialAsync("_AdminTour"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"content-header clearfix\">\r\n    <h1 class=\"float-left\">\r\n        ");
#nullable restore
#line 28 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
   Write(T("Admin.ContentManagement.Topics"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"float-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "433090704cf1b9144e9bfc91ed3d2b185ed61dd716020", async() => {
                WriteLiteral("\r\n            <i class=\"fas fa-plus-square\"></i>\r\n            ");
#nullable restore
#line 33 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
       Write(T("Admin.Common.AddNew"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
#nullable restore
#line 35 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
   Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.TopicListButtons }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<section class=""content"">
    <div class=""container-fluid"">
    <div class=""form-horizontal"">
        <div class=""cards-group"">
            <div class=""card card-default card-search"">
                <div class=""card-body"">
                    <div");
            BeginWriteAttribute("class", " class=\"", 1522, "\"", 1580, 3);
            WriteAttributeValue("", 1530, "row", 1530, 3, true);
            WriteAttributeValue(" ", 1533, "search-row", 1534, 11, true);
#nullable restore
#line 45 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
WriteAttributeValue(" ", 1544, !hideSearchBlock ? "opened" : "", 1545, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-hideAttribute=\"");
#nullable restore
#line 45 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
                                                                                                   Write(hideSearchBlockAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <div class=\"search-text\">");
#nullable restore
#line 46 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
                                            Write(T("Admin.Common.Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"icon-search\"><i class=\"fas fa-search\" aria-hidden=\"true\"></i></div>\r\n                        <div class=\"icon-collapse\"><i");
            BeginWriteAttribute("class", " class=\"", 1875, "\"", 1931, 3);
            WriteAttributeValue("", 1883, "far", 1883, 3, true);
            WriteAttributeValue(" ", 1886, "fa-angle-", 1887, 10, true);
#nullable restore
#line 48 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
WriteAttributeValue("", 1896, !hideSearchBlock ? "up" : "down", 1896, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\"></i></div>\r\n                    </div>\r\n\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 2018, "\"", 2072, 2);
            WriteAttributeValue("", 2026, "search-body", 2026, 11, true);
#nullable restore
#line 51 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
WriteAttributeValue(" ", 2037, hideSearchBlock ? "closed" : "", 2038, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group row\" ");
#nullable restore
#line 54 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
                                                        Write(Model.HideStoresList ? Html.Raw("style=\"display:none\"") : null);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    <div class=\"col-md-4\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "433090704cf1b9144e9bfc91ed3d2b185ed61dd721183", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 56 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchStoreId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "433090704cf1b9144e9bfc91ed3d2b185ed61dd722777", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper);
#nullable restore
#line 59 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchStoreId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items = Model.AvailableStores;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"form-group row\">\r\n                                    <div class=\"col-md-4\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "433090704cf1b9144e9bfc91ed3d2b185ed61dd724951", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 64 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchKeywords);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "433090704cf1b9144e9bfc91ed3d2b185ed61dd726546", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 67 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchKeywords);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-8 offset-md-4"">
                                <button type=""button"" id=""search-topics"" class=""btn btn-primary btn-search"">
                                    <i class=""fas fa-search""></i>
                                    ");
#nullable restore
#line 76 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
                               Write(T("Admin.Common.Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""card card-default"">
                <div class=""card-body"" id=""topics-area"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-doc-reference", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "433090704cf1b9144e9bfc91ed3d2b185ed61dd729047", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopDocReferenceTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
                                                WriteLiteral(T("Admin.Documentation.Reference.TopicsPages", Docs.TopicsPages + Utm.OnAdmin));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper.StringResource = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-string-resource", __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper.StringResource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 88 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
               Write(await Html.PartialAsync("Table", new DataTablesModel
                    {
                        Name = "topics-grid",
                        RowIdBasedOnField = nameof(TopicModel.TopicName),
                        UrlRead = new DataUrl("List", "Topic", null),
                        SearchButtonId = "search-topics",
                        Length = Model.PageSize,
                        LengthMenu = Model.AvailablePageSizes,
                        Filters = new List<FilterParameter>
                        {
                            new FilterParameter(nameof(Model.SearchKeywords)),
                            new FilterParameter(nameof(Model.SearchStoreId))
                        },
                        ColumnCollection = new List<ColumnProperty>
                        {
                            new ColumnProperty(nameof(TopicModel.TopicName))
                            {
                                Title = T("Admin.ContentManagement.Topics.Fields.TopicName").Text
                            },
                            new ColumnProperty(nameof(TopicModel.Published))
                            {
                                Title = T("Admin.ContentManagement.Topics.Fields.Published").Text,
                                Width = "150",
                                ClassName = NopColumnClassDefaults.CenterAll,
                                Render = new RenderBoolean()
                            },
                            new ColumnProperty(nameof(TopicModel.IsPasswordProtected))
                            {
                                Title = T("Admin.ContentManagement.Topics.Fields.IsPasswordProtected").Text,
                                Width = "150",
                                ClassName = NopColumnClassDefaults.CenterAll,
                                Render = new RenderBoolean()
                            },
                            new ColumnProperty(nameof(TopicModel.IncludeInSitemap))
                            {
                                Title = T("Admin.ContentManagement.Topics.Fields.IncludeInSitemap").Text,
                                Width = "150",
                                ClassName = NopColumnClassDefaults.CenterAll,
                                Render = new RenderBoolean()
                            },
                            new ColumnProperty(nameof(TopicModel.IncludeInTopMenu))
                            {
                                Title = T("Admin.ContentManagement.Topics.Fields.IncludeInTopMenu").Text,
                                Width = "150",
                                ClassName = NopColumnClassDefaults.CenterAll,
                                Render = new RenderBoolean()
                            },
                            new ColumnProperty(nameof(TopicModel.IncludeInFooterColumn1))
                            {
                                Title = T("Admin.ContentManagement.Topics.Fields.IncludeInFooterColumn1").Text,
                                Width = "150",
                                ClassName = NopColumnClassDefaults.CenterAll + " column-footer-column1",
                                Render = new RenderBoolean()
                            },
                            new ColumnProperty(nameof(TopicModel.IncludeInFooterColumn2))
                            {
                                Title = T("Admin.ContentManagement.Topics.Fields.IncludeInFooterColumn2").Text,
                                Width = "150",
                                ClassName = NopColumnClassDefaults.CenterAll,
                                Render = new RenderBoolean()
                            },
                            new ColumnProperty(nameof(TopicModel.IncludeInFooterColumn3))
                            {
                                Title = T("Admin.ContentManagement.Topics.Fields.IncludeInFooterColumn3").Text,
                                Width = "150",
                                ClassName = NopColumnClassDefaults.CenterAll,
                                Render = new RenderBoolean()
                            },
                            new ColumnProperty(nameof(TopicModel.DisplayOrder))
                            {
                                Title = T("Admin.ContentManagement.Topics.Fields.DisplayOrder").Text,
                                Width = "100",
                                ClassName = NopColumnClassDefaults.CenterAll
                            },
                            new ColumnProperty(nameof(TopicModel.Id))
                            {
                                Title = T("Admin.Common.Edit").Text,
                                Width = "100",
                                ClassName = NopColumnClassDefaults.Button + " column-edit",
                                Render = new RenderCustom("renderColumnEdit")
                            }
                        }
                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</section>\r\n\r\n<script>\r\n    function renderColumnEdit(data, type, row, meta) {\r\n        return \'<a href=\"");
#nullable restore
#line 180 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
                    Write(Url.Content("~/Admin/Topic/Edit/"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + data + \'");
#nullable restore
#line 180 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
                                                                    Write(editQueryString);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-default\"><i class=\"fas fa-pencil-alt\"></i>");
#nullable restore
#line 180 "F:\new clone\Presentation\Nop.Web\Areas\Admin\Views\Contract\List.cshtml"
                                                                                                                                                Write(T("Admin.Common.Edit").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\';\r\n    }\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Topics.ITopicService topicService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopicSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

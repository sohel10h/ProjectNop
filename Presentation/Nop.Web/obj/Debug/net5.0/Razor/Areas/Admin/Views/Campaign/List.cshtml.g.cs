#pragma checksum "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36680330c68e328c97f010d480bfe3f3661c9fe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Campaign_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Campaign/List.cshtml")]
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
#line 9 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.MultiFactorAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36680330c68e328c97f010d480bfe3f3661c9fe9", @"/Areas/Admin/Views/Campaign/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181066c519b5e3a88fbfc1b430cb86e3463f4c97", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Campaign_List : Nop.Web.Framework.Mvc.Razor.NopRazorPage<CampaignSearchModel>
    {
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
        private global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopDocReferenceTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
  
    //page title
    ViewBag.PageTitle = T("Admin.Promotions.Campaigns").Text;
    //active menu item (system name)
    Html.SetActiveMenuItemSystemName("Campaigns");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
  
    const string hideSearchBlockAttributeName = "CampaignPage.HideSearchBlock";
    var hideSearchBlock = await genericAttributeService.GetAttributeAsync<bool>(await workContext.GetCurrentCustomerAsync(), hideSearchBlockAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"content-header clearfix\">\r\n    <h1 class=\"float-left\">\r\n        ");
#nullable restore
#line 18 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
   Write(T("Admin.Promotions.Campaigns"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"float-right\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 621, "\"", 649, 1);
#nullable restore
#line 21 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
WriteAttributeValue("", 628, Url.Action("Create"), 628, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">\r\n            <i class=\"fas fa-plus-square\"></i>\r\n            ");
#nullable restore
#line 23 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
       Write(T("Admin.Common.AddNew"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n        ");
#nullable restore
#line 25 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
   Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.CampaignListButtons }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<section class=\"content\">\r\n    <div class=\"container-fluid\">\r\n    <div class=\"form-horizontal\">\r\n        <div class=\"cards-group\">\r\n");
            WriteLiteral("            <div class=\"card card-default card-search\" ");
#nullable restore
#line 34 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
                                                   Write(Model.HideStoresList ? Html.Raw("style=\"display:none\"") : null);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                <div class=\"card-body\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1309, "\"", 1367, 3);
            WriteAttributeValue("", 1317, "row", 1317, 3, true);
            WriteAttributeValue(" ", 1320, "search-row", 1321, 11, true);
#nullable restore
#line 36 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
WriteAttributeValue(" ", 1331, !hideSearchBlock ? "opened" : "", 1332, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-hideAttribute=\"");
#nullable restore
#line 36 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
                                                                                                   Write(hideSearchBlockAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <div class=\"search-text\">");
#nullable restore
#line 37 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
                                            Write(T("Admin.Common.Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"icon-search\"><i class=\"fas fa-search\" aria-hidden=\"true\"></i></div>\r\n                        <div class=\"icon-collapse\"><i");
            BeginWriteAttribute("class", " class=\"", 1662, "\"", 1718, 3);
            WriteAttributeValue("", 1670, "far", 1670, 3, true);
            WriteAttributeValue(" ", 1673, "fa-angle-", 1674, 10, true);
#nullable restore
#line 39 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
WriteAttributeValue("", 1683, !hideSearchBlock ? "up" : "down", 1683, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\"></i></div>\r\n                    </div>\r\n\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1805, "\"", 1859, 2);
            WriteAttributeValue("", 1813, "search-body", 1813, 11, true);
#nullable restore
#line 42 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
WriteAttributeValue(" ", 1824, hideSearchBlock ? "closed" : "", 1825, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group row"">
                                    <div class=""col-md-4"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36680330c68e328c97f010d480bfe3f3661c9fe919049", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 47 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StoreId);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36680330c68e328c97f010d480bfe3f3661c9fe920638", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper);
#nullable restore
#line 50 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StoreId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 50 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
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
            WriteLiteral(@"
                                    </div>
                                </div>                                
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-8 offset-md-4"">
                                <button type=""button"" id=""search-campaigns"" class=""btn btn-primary btn-search"">
                                    <i class=""fas fa-search""></i>
                                    ");
#nullable restore
#line 59 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
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
                <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-doc-reference", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36680330c68e328c97f010d480bfe3f3661c9fe923617", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopDocReferenceTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
                                                WriteLiteral(T("Admin.Documentation.Reference.EmailCampaigns", Docs.EmailCampaigns + Utm.OnAdmin));

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
#line 71 "D:\ProjectNop\Presentation\Nop.Web\Areas\Admin\Views\Campaign\List.cshtml"
               Write(await Html.PartialAsync("Table", new DataTablesModel
                    {
                        Name = "campaigns-grid",
                        UrlRead = new DataUrl("List", "Campaign", null),
                        SearchButtonId = "search-campaigns",
                        Length = Model.PageSize,
                        LengthMenu = Model.AvailablePageSizes,
                        Filters = new List<FilterParameter>
                        {
                            new FilterParameter(nameof(Model.StoreId))
                        },
                        ColumnCollection = new List<ColumnProperty>
                        {
                            new ColumnProperty(nameof(CampaignModel.Name))
                            {
                                Title = T("Admin.Promotions.Campaigns.Fields.Name").Text
                            },
                            new ColumnProperty(nameof(CampaignModel.CreatedOn))
                            {
                                Title = T("Admin.Promotions.Campaigns.Fields.CreatedOn").Text,
                                Width = "200",
                                Render = new RenderDate()
                            },
                            new ColumnProperty(nameof(CampaignModel.DontSendBeforeDate))
                            {
                                Title = T("Admin.Promotions.Campaigns.Fields.DontSendBeforeDate").Text,
                                Width = "200",
                                Render = new RenderDate()
                            },
                            new ColumnProperty(nameof(CampaignModel.Id))
                            {
                                Title = T("Admin.Common.Edit").Text,
                                Width = "100",
                                ClassName = NopColumnClassDefaults.Button,
                                Render = new RenderButtonEdit(new DataUrl("Edit"))
                            }
                        }
                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</section>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CampaignSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

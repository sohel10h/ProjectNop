#pragma checksum "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c34b8608c704ad134c85cda8602b84dc8aa185"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog__CatalogSelectors), @"mvc.1.0.view", @"/Views/Catalog/_CatalogSelectors.cshtml")]
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
#line 9 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44c34b8608c704ad134c85cda8602b84dc8aa185", @"/Views/Catalog/_CatalogSelectors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d1b9cf4fa5ba34fd858c89c406a07634618cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog__CatalogSelectors : Nop.Web.Framework.Mvc.Razor.NopRazorPage<CatalogProductsModel>
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
        private global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
 if (Model.Products.Count <= 0 &&
     !Model.PriceRangeFilter.Enabled &&
     !Model.SpecificationFilter.Enabled &&
     !Model.ManufacturerFilter.Enabled)
{
    return;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"product-selectors\">\r\n");
#nullable restore
#line 13 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
     if (Model.AllowProductViewModeChanging)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product-viewmode\">\r\n            <span>");
#nullable restore
#line 16 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
             Write(T("Catalog.ViewMode"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 17 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
             if (Model.AvailableViewModes.Count > 1)
            {
                var gridMode = Model.AvailableViewModes[0];
                var listMode = Model.AvailableViewModes[1];


#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("class", " class=\"", 618, "\"", 691, 3);
            WriteAttributeValue("", 626, "viewmode-icon", 626, 13, true);
            WriteAttributeValue(" ", 639, "grid", 640, 5, true);
            WriteAttributeValue(" ", 644, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 22 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
                                              if (gridMode.Selected){

#line default
#line hidden
#nullable disable
                WriteLiteral("selected");
#nullable restore
#line 22 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
                                                                                          }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 645, 46, false);
            EndWriteAttribute();
            WriteLiteral(" data-viewmode=\"");
#nullable restore
#line 22 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
                                                                                                       Write(gridMode.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("title", " title=\"", 724, "\"", 746, 1);
#nullable restore
#line 22 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
WriteAttributeValue("", 732, gridMode.Text, 732, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
                                                                                                                                               Write(gridMode.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <a");
            BeginWriteAttribute("class", " class=\"", 786, "\"", 859, 3);
            WriteAttributeValue("", 794, "viewmode-icon", 794, 13, true);
            WriteAttributeValue(" ", 807, "list", 808, 5, true);
            WriteAttributeValue(" ", 812, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 23 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
                                              if (listMode.Selected){

#line default
#line hidden
#nullable disable
                WriteLiteral("selected");
#nullable restore
#line 23 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
                                                                                          }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 813, 46, false);
            EndWriteAttribute();
            WriteLiteral(" data-viewmode=\"");
#nullable restore
#line 23 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
                                                                                                       Write(listMode.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("title", " title=\"", 892, "\"", 914, 1);
#nullable restore
#line 23 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
WriteAttributeValue("", 900, listMode.Text, 900, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
                                                                                                                                               Write(listMode.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 24 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c34b8608c704ad134c85cda8602b84dc8aa18514868", async() => {
                WriteLiteral(@"
            $(document).ready(function () {
                var $viewModeEls = $('[data-viewmode]');
                $viewModeEls.on('click', function () {
                    if (!$(this).hasClass('selected')) {
                        $viewModeEls.toggleClass('selected');
                        CatalogProducts.getProducts();
                    }
                    return false;
                });

                $(CatalogProducts).on('before', function (e) {
                    var $viewModeEl = $('[data-viewmode].selected');
                    if ($viewModeEl) {
                        e.payload.urlBuilder
                            .addParameter('viewmode', $viewModeEl.data('viewmode'));
                    }
                });
            });
        ");
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper);
#nullable restore
#line 26 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location = global::Nop.Web.Framework.UI.ResourceLocation.Footer;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-location", __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 48 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
     if (Model.AllowProductSorting)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product-sorting\">\r\n            <span>");
#nullable restore
#line 51 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
             Write(T("Catalog.OrderBy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            ");
#nullable restore
#line 52 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
       Write(Html.DropDownList("products-orderby", Model.AvailableSortOptions, new { aria_label = T("Catalog.OrderBy.Label") }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c34b8608c704ad134c85cda8602b84dc8aa18518321", async() => {
                WriteLiteral(@"
            $(document).ready(function () {
                var $orderByEl = $('#products-orderby');
                $orderByEl.on('change', function () {
                    CatalogProducts.getProducts();
                });

                $(CatalogProducts).on('before', function (e) {
                    e.payload.urlBuilder
                        .addParameter('orderby', $orderByEl.val());
                });
            });
        ");
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper);
#nullable restore
#line 54 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location = global::Nop.Web.Framework.UI.ResourceLocation.Footer;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-location", __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 67 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 69 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
     if (Model.AllowCustomersToSelectPageSize)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product-page-size\">\r\n            <span>");
#nullable restore
#line 72 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
             Write(T("Catalog.PageSize"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            ");
#nullable restore
#line 73 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
       Write(Html.DropDownList("products-pagesize", Model.PageSizeOptions, new { aria_label = T("Catalog.PageSize.Label") }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span>");
#nullable restore
#line 74 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
             Write(T("Catalog.PageSize.PerPage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c34b8608c704ad134c85cda8602b84dc8aa18521737", async() => {
                WriteLiteral(@"
            $(document).ready(function () {
                var $pageSizeEl = $('#products-pagesize');
                $pageSizeEl.on('change', function () {
                    CatalogProducts.getProducts();
                });

                $(CatalogProducts).on('before', function (e) {
                    e.payload.urlBuilder
                        .addParameter('pagesize', $pageSizeEl.val());
                });
            });
        ");
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper);
#nullable restore
#line 76 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location = global::Nop.Web.Framework.UI.ResourceLocation.Footer;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-location", __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 89 "D:\Personal works\Scripts\ProjectNop\Presentation\Nop.Web\Views\Catalog\_CatalogSelectors.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogProductsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "787c687e338de217ee1a680428ea9d8bc50bf32e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_CompareProducts), @"mvc.1.0.view", @"/Views/Product/CompareProducts.cshtml")]
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
#line 9 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"787c687e338de217ee1a680428ea9d8bc50bf32e", @"/Views/Product/CompareProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d1b9cf4fa5ba34fd858c89c406a07634618cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_CompareProducts : Nop.Web.Framework.Mvc.Razor.NopRazorPage<CompareProductsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
  
    Layout = "_ColumnsTwo";

    //title
    Html.AddTitleParts(T("PageTitle.CompareProducts").Text);
    //page class
    Html.AppendPageCssClassParts("html-compare-products-page");

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
  
    var columnWidth = "";
    if (Model.Products.Count > 0)
    {
        columnWidth = Math.Round((decimal)(90M / Model.Products.Count), 0).ToString() + "%";
    }

    var uniqueGroupes = new List<ProductSpecificationAttributeGroupModel>();
    foreach (var group in Model.Products.SelectMany(p => p.ProductSpecificationModel.Groups))
    {
        if (!uniqueGroupes.Any(g => g.Id == group.Id))
            uniqueGroupes.Add(group);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"page compare-products-page\">\r\n    <div class=\"page-title\">\r\n        <h1>");
#nullable restore
#line 26 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
       Write(T("Products.Compare.Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"page-body\">\r\n");
#nullable restore
#line 29 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
         if (Model.Products.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 920, "\"", 978, 3);
            WriteAttributeValue("", 930, "setLocation(\'", 930, 13, true);
#nullable restore
#line 31 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue("", 943, Url.RouteUrl("ClearCompareList"), 943, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 976, "\')", 976, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"clear-list\">");
#nullable restore
#line 31 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                                                                                 Write(T("Products.Compare.Clear"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <div class=\"table-wrapper\">\r\n                <table class=\"compare-products-table\">\r\n                    <tbody>\r\n                        <tr class=\"remove-product\">\r\n                            <td class=\"empty\">&nbsp;</td>\r\n");
#nullable restore
#line 37 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                             foreach (var product in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td");
            BeginWriteAttribute("style", " style=\"", 1407, "\"", 1435, 3);
            WriteAttributeValue("", 1415, "width:", 1415, 6, true);
#nullable restore
#line 39 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue(" ", 1421, columnWidth, 1422, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1434, ";", 1434, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <button type=\"button\" class=\"button-2 remove-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1527, "\"", 1629, 3);
            WriteAttributeValue("", 1537, "setLocation(\'", 1537, 13, true);
#nullable restore
#line 40 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue("", 1550, Url.RouteUrl("RemoveProductFromCompareList", new { productId = product.Id }), 1550, 77, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1627, "\')", 1627, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                                                                                                                                                                           Write(T("Common.Remove"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                </td>\r\n");
#nullable restore
#line 42 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n                        <tr class=\"product-picture\">\r\n                            <td class=\"empty\">&nbsp;</td>\r\n");
#nullable restore
#line 46 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                             foreach (var product in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td");
            BeginWriteAttribute("style", " style=\"", 2011, "\"", 2039, 3);
            WriteAttributeValue("", 2019, "width:", 2019, 6, true);
#nullable restore
#line 48 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue(" ", 2025, columnWidth, 2026, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2038, ";", 2038, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"picture\"");
            BeginWriteAttribute("href", " href=\"", 2097, "\"", 2161, 1);
#nullable restore
#line 49 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue("", 2104, Url.RouteUrl("Product", new { SeName = product.SeName }), 2104, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("alt", " alt=\"", 2167, "\"", 2215, 1);
#nullable restore
#line 49 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue("", 2173, product.DefaultPictureModel.AlternateText, 2173, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 2216, "\"", 2259, 1);
#nullable restore
#line 49 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue("", 2222, product.DefaultPictureModel.ImageUrl, 2222, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2260, "\"", 2302, 1);
#nullable restore
#line 49 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue("", 2268, product.DefaultPictureModel.Title, 2268, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                </td>\r\n");
#nullable restore
#line 51 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n                        <tr class=\"product-name\">\r\n                            <td>\r\n                                <label>");
#nullable restore
#line 55 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                  Write(T("Products.Compare.Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </td>\r\n");
#nullable restore
#line 57 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                             foreach (var product in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td");
            BeginWriteAttribute("style", " style=\"", 2745, "\"", 2773, 3);
            WriteAttributeValue("", 2753, "width:", 2753, 6, true);
#nullable restore
#line 59 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue(" ", 2759, columnWidth, 2760, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2772, ";", 2772, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2815, "\"", 2879, 1);
#nullable restore
#line 60 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue("", 2822, Url.RouteUrl("Product", new { SeName = product.SeName }), 2822, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 60 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                                                                                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </td>\r\n");
#nullable restore
#line 62 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n                        <tr class=\"product-price\">\r\n                            <td>\r\n                                <label>");
#nullable restore
#line 66 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                  Write(T("Products.Compare.Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </td>\r\n");
#nullable restore
#line 68 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                             foreach (var product in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td");
            BeginWriteAttribute("style", " style=\"", 3335, "\"", 3363, 3);
            WriteAttributeValue("", 3343, "width:", 3343, 6, true);
#nullable restore
#line 70 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue(" ", 3349, columnWidth, 3350, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3362, ";", 3362, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 71 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                               Write(product.ProductPrice.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 73 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 75 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                         if (Model.IncludeShortDescriptionInCompareProducts)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"short-description\">\r\n                                <td>\r\n                                    <label>");
#nullable restore
#line 79 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                      Write(T("Products.Compare.ShortDescription"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                </td>\r\n");
#nullable restore
#line 81 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                 foreach (var product in Model.Products)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td");
            BeginWriteAttribute("style", " style=\"", 4015, "\"", 4043, 3);
            WriteAttributeValue("", 4023, "width:", 4023, 6, true);
#nullable restore
#line 83 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue(" ", 4029, columnWidth, 4030, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4042, ";", 4042, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 84 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                   Write(Html.Raw(product.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
#nullable restore
#line 86 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 88 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                         if (Model.IncludeFullDescriptionInCompareProducts)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"full-description\">\r\n                                <td>\r\n                                    <label>");
#nullable restore
#line 93 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                      Write(T("Products.Compare.FullDescription"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                </td>\r\n");
#nullable restore
#line 95 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                 foreach (var product in Model.Products)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td");
            BeginWriteAttribute("style", " style=\"", 4743, "\"", 4771, 3);
            WriteAttributeValue("", 4751, "width:", 4751, 6, true);
#nullable restore
#line 97 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue(" ", 4757, columnWidth, 4758, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4770, ";", 4770, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 98 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                   Write(Html.Raw(product.FullDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
#nullable restore
#line 100 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 102 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                         foreach (var group in uniqueGroupes)
                        {
                            if (group.Attributes.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                 if (group.Id > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"specification-group\">\r\n                                        <td>\r\n                                            <label>");
#nullable restore
#line 111 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                              Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 114 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                 

                                var uniqueGroupAttributes = new List<ProductSpecificationAttributeModel>();
                                foreach (var attribute in Model.Products.SelectMany(p => p.ProductSpecificationModel.Groups.Where(g => g.Id == group.Id).SelectMany(g => g.Attributes)))
                                {
                                    if (!uniqueGroupAttributes.Any(sa => sa.Id == attribute.Id))
                                        uniqueGroupAttributes.Add(attribute);
                                }
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                 foreach (var specificationAttribute in uniqueGroupAttributes)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"specification\">\r\n                                        <td>\r\n                                            <label>");
#nullable restore
#line 126 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                              Write(specificationAttribute.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                        </td>\r\n");
#nullable restore
#line 128 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                         foreach (var product in Model.Products)
                                        {
                                            var foundProductSpec = product.ProductSpecificationModel.Groups
                                                .Where(g => g.Id == group.Id)
                                                .SelectMany(g => g.Attributes)
                                                .FirstOrDefault(sa => sa.Id == specificationAttribute.Id);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td");
            BeginWriteAttribute("style", " style=\"", 7044, "\"", 7072, 3);
            WriteAttributeValue("", 7052, "width:", 7052, 6, true);
#nullable restore
#line 135 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue(" ", 7058, columnWidth, 7059, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7071, ";", 7071, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 136 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                                 if (foundProductSpec != null)
                                                {
                                                    for (int i = 0; i < foundProductSpec.Values.Count; i++)
                                                    {
                                                        var value = foundProductSpec.Values[i];

                                                        if (string.IsNullOrEmpty(value.ColorSquaresRgb))
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                                       Write(Html.Raw(value.ValueRaw));

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                                                                     
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"attribute-squares color-squares\">\r\n                                                                <span class=\"attribute-square-container\"");
            BeginWriteAttribute("title", " title=\"", 8113, "\"", 8146, 1);
#nullable restore
#line 149 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue("", 8121, Html.Raw(value.ValueRaw), 8121, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                    <span class=\"attribute-square\"");
            BeginWriteAttribute("style", " style=\"", 8248, "\"", 8299, 3);
            WriteAttributeValue("", 8256, "background-color:", 8256, 17, true);
#nullable restore
#line 150 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
WriteAttributeValue(" ", 8273, value.ColorSquaresRgb, 8274, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8298, ";", 8298, 1, true);
            EndWriteAttribute();
            WriteLiteral(">&nbsp;</span>\r\n                                                                </span>\r\n                                                            </div>\r\n");
#nullable restore
#line 153 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                                        }

                                                        if (i != foundProductSpec.Values.Count - 1)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
            WriteLiteral(",&nbsp;");
#nullable restore
#line 157 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                                                                
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;");
#nullable restore
#line 163 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                                                       
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n");
#nullable restore
#line 166 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 168 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
                                 
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
#nullable restore
#line 174 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"no-data\">\r\n                ");
#nullable restore
#line 178 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
           Write(T("Products.Compare.NoItems"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 180 "D:\Personal works\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Product\CompareProducts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompareProductsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

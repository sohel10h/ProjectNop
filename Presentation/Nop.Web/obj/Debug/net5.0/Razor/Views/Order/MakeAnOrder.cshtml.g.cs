#pragma checksum "D:\ProjectNop\Presentation\Nop.Web\Views\Order\MakeAnOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ebaa247d91dc8de752576bdada43b88dd3d37af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_MakeAnOrder), @"mvc.1.0.view", @"/Views/Order/MakeAnOrder.cshtml")]
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
#line 9 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ebaa247d91dc8de752576bdada43b88dd3d37af", @"/Views/Order/MakeAnOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d1b9cf4fa5ba34fd858c89c406a07634618cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_MakeAnOrder : Nop.Web.Framework.Mvc.Razor.NopRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeAnOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("category-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ProjectNop\Presentation\Nop.Web\Views\Order\MakeAnOrder.cshtml"
  
    Layout = "_ColumnsOne";

    //title
    Html.AddTitleParts(T("PageTitle.ShipmentDetails").Text);
    //page class
    Html.AppendPageCssClassParts("html-shipment-details-page");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ebaa247d91dc8de752576bdada43b88dd3d37af10162", async() => {
                WriteLiteral(@"
    <div id=""make_an_order"">
        <div class=""mnoContainer header_container"">
            <div class=""product_name_dv""> Product Name</div>
            <div class=""pproduct_quantity_dv""> Quantity</div>
            <div class=""pproduct_img_dv""> Image</div>
        </div>
        <div class=""mnoContainer"">
            <input type=""hidden"" value=""0"" class=""productid"" name=""id0"" />
            <div class=""product_name_dv""> <input type=""text"" class=""product_name"" name=""name0"" /> <span class=""product_price""></span></div>
            <div class=""pproduct_quantity_dv""> <input type=""number"" name=""quantity0"" min=""1"" value=""1"" class=""product_qty"" /></div>
            <div class=""pproduct_img_dv""> <input name=""image0"" type=""file"" accept=""image/png, image/jpeg"" class=""product_img"" /></div>
        </div>

        <div class=""mnoContainer"">
            <input type=""hidden"" class=""productid"" value=""0"" name=""id1"" />
            <div class=""product_name_dv""> <input type=""text"" class=""product_name"" name=""nam");
                WriteLiteral(@"e1"" /><span class=""product_price""></span></div>
            <div class=""pproduct_quantity_dv""> <input type=""number"" name=""quantity1"" min=""1"" value=""1"" class=""product_qty"" /></div>
            <div class=""pproduct_img_dv""> <input name=""image1"" type=""file"" accept=""image/png, image/jpeg"" class=""product_img"" /></div>
        </div>
        <div class=""mnoContainer"">
            <input type=""hidden"" class=""productid"" value=""0"" name=""id2"" />
            <div class=""product_name_dv""> <input type=""text"" class=""product_name"" name=""name2"" /><span class=""product_price""></span></div>
            <div class=""pproduct_quantity_dv""> <input type=""number"" name=""quantity2"" min=""1"" value=""1"" class=""product_qty"" /></div>
            <div class=""pproduct_img_dv""> <input name=""image2"" type=""file"" accept=""image/png, image/jpeg"" class=""product_img"" /></div>
        </div>
        <div class=""mnoContainer"">
            <input type=""hidden"" class=""productid"" value=""0"" name=""id3"" />
            <div class=""product_name_dv"">");
                WriteLiteral(@" <input type=""text"" class=""product_name"" name=""name3"" /><span class=""product_price""></span></div>
            <div class=""pproduct_quantity_dv""> <input type=""number"" name=""quantity3"" min=""1"" value=""1"" class=""product_qty"" /></div>
            <div class=""pproduct_img_dv""> <input name=""image3"" type=""file"" accept=""image/png, image/jpeg"" class=""product_img"" /></div>
        </div>
        <div class=""mnoContainer"">
            <input type=""hidden"" class=""productid"" value=""0"" name=""id4"" />
            <div class=""product_name_dv""> <input type=""text"" class=""product_name"" name=""name4"" /><span class=""product_price""></span></div>
            <div class=""pproduct_quantity_dv""> <input type=""number"" name=""quantity4"" min=""1"" value=""1"" class=""product_qty"" /></div>
            <div class=""pproduct_img_dv""> <input name=""image4"" type=""file"" accept=""image/png, image/jpeg"" class=""product_img"" /></div>
        </div>
        <div class=""mnoContainer"">
            <input type=""hidden"" class=""productid"" value=""0"" name=""");
                WriteLiteral(@"id5"" />
            <div class=""product_name_dv""> <input type=""text"" class=""product_name"" name=""name5"" /><span class=""product_price""></span></div>
            <div class=""pproduct_quantity_dv""> <input type=""number"" name=""quantity5"" min=""1"" value=""1"" class=""product_qty"" /></div>
            <div class=""pproduct_img_dv""> <input name=""image5"" type=""file"" accept=""image/png, image/jpeg"" class=""product_img"" /></div>
        </div>
        <div class=""mnoContainer"">
            <input type=""hidden"" class=""productid"" value=""0"" name=""id6"" />
            <div class=""product_name_dv""> <input type=""text"" class=""product_name"" name=""name6"" /><span class=""product_price""></span></div>
            <div class=""pproduct_quantity_dv""> <input type=""number"" name=""quantity6"" min=""1"" value=""1"" class=""product_qty"" /></div>
            <div class=""pproduct_img_dv""> <input name=""image6"" type=""file"" accept=""image/png, image/jpeg"" class=""product_img"" /></div>
        </div>
        <button id=""upload_order"">Make Order</button>");
                WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ebaa247d91dc8de752576bdada43b88dd3d37af16756", async() => {
                WriteLiteral("\r\n    $(\".product_name\").autocomplete({\r\n        source: \'");
#nullable restore
#line 72 "D:\ProjectNop\Presentation\Nop.Web\Views\Order\MakeAnOrder.cshtml"
             Write(Url.RouteUrl("SearchTermAutoCompleteForOrder"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
        minLength:4,
        select: function (event, ui)
        {
            debugger;
            console.log(ui);
            var id = $(this).attr(""name"").replace(""name"", '');
            $('input.productid[name=""id' + id + '""]').val(ui.item.id);
            $(this).parents("".mnoContainer"").find("".product_price"").html(ui.item.price.Price);
            $(this).val(ui.item.label);
            $(this).parents("".mnoContainer"").find(""input.product_img"").css(""display"", ""none"");            
            return false;
        },
    });

    ");
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper);
#nullable restore
#line 70 "D:\ProjectNop\Presentation\Nop.Web\Views\Order\MakeAnOrder.cshtml"
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
            WriteLiteral(@"



    <style>

        span.product_price {
            color: green;
            font-weight: 700;
        }

        .mnoContainer.header_container {
            width: 80%;
            margin: 10px auto 35px auto;
            border-bottom: 1px solid #beb5b5;
            padding-bottom: 8px;
        }
        button#upload_order {
            height: 100px;
            width: 100px;
            border-radius: 100%;
            display: block;
            margin: 30px auto;
        }

        .product_name_dv, .pproduct_quantity_dv, .pproduct_img_dv {
            display: inline-block;
            padding: 10px 30px 0px 10px;
        }

        input.product_name {
            width: 500px;
            border-radius: 5px;
        }

        input.product_qty {
            height: 30px;
            width: 100px;
            border-radius: 5px;
            border: 1px solid #d3cdcd;
            text-align: center;
        }

        .mnoContainer:not(.header_contai");
            WriteLiteral(@"ner) {
            width: 80%;
            margin: 10px auto 35px auto;
            box-shadow: 4px 4px 10px 4px #cac6c6;
            padding-bottom: 10px;
            border-radius: 5px;
        }

        .header_container .pproduct_img_dv, .header_container .pproduct_quantity_dv {
            width: 200px;
            text-align: center;
        }

        .header_container .product_name_dv {
            width: 500px;
            text-align: center;
        }
    </style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

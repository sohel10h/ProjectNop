#pragma checksum "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d378e8afa72f02363a75f2b6029f94a478ff50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PrivateMessages_SendPM), @"mvc.1.0.view", @"/Views/PrivateMessages/SendPM.cshtml")]
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
#line 9 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d378e8afa72f02363a75f2b6029f94a478ff50", @"/Views/PrivateMessages/SendPM.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d1b9cf4fa5ba34fd858c89c406a07634618cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_PrivateMessages_SendPM : Nop.Web.Framework.Mvc.Razor.NopRazorPage<SendPrivateMessageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("message-error"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pm-title-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bb-editor-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "SendPM", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper __Nop_Web_Framework_TagHelpers_Public_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.NopBBCodeEditorTagHelper __Nop_Web_Framework_TagHelpers_Public_NopBBCodeEditorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.TextAreaTagHelper __Nop_Web_Framework_TagHelpers_Public_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
      
    Layout = "_ColumnsOne";

    //title
    Html.AddTitleParts(T("PageTitle.SendPM").Text);
    //page class
    Html.AppendPageCssClassParts("html-private-messages");
    Html.AppendPageCssClassParts("html-private-message-send-page");

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d378e8afa72f02363a75f2b6029f94a478ff5011582", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d378e8afa72f02363a75f2b6029f94a478ff5011845", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 12 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"page private-messages private-message-send-page\">\r\n        <div class=\"page-title\">\r\n            <h1>");
#nullable restore
#line 15 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
           Write(T("PrivateMessages.Send.PostMessage"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"page-body\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35d378e8afa72f02363a75f2b6029f94a478ff5013968", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
                __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ToCustomerId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35d378e8afa72f02363a75f2b6029f94a478ff5015688", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
                __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 19 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReplyToMessageId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"fieldset\">\r\n                <div class=\"form-fields\">\r\n                    <div class=\"inputs\">\r\n                        <label>");
#nullable restore
#line 23 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
                          Write(T("PrivateMessages.Send.To"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 24 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
                         if (Model.AllowViewingToProfile)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 1043, "\"", 1113, 1);
#nullable restore
#line 26 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
WriteAttributeValue("", 1050, Url.RouteUrl("CustomerProfile", new {id = Model.ToCustomerId}), 1050, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 26 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
                                                                                                  Write(Model.CustomerToName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 27 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span>");
#nullable restore
#line 30 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
                             Write(Model.CustomerToName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 31 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <div class=\"inputs\">\r\n                        <label>");
#nullable restore
#line 34 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
                          Write(T("PrivateMessages.Send.Subject"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35d378e8afa72f02363a75f2b6029f94a478ff5020118", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
#nullable restore
#line 35 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Subject);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d378e8afa72f02363a75f2b6029f94a478ff5021716", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 36 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Subject);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"inputs message\">\r\n                        <label>");
#nullable restore
#line 39 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
                          Write(T("PrivateMessages.Send.Message"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-bb-code-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35d378e8afa72f02363a75f2b6029f94a478ff5023695", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Public_NopBBCodeEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.NopBBCodeEditorTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_NopBBCodeEditorTagHelper);
#nullable restore
#line 40 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
__Nop_Web_Framework_TagHelpers_Public_NopBBCodeEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_NopBBCodeEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d378e8afa72f02363a75f2b6029f94a478ff5025269", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __Nop_Web_Framework_TagHelpers_Public_TextAreaTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_TextAreaTagHelper);
#nullable restore
#line 41 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Nop_Web_Framework_TagHelpers_Public_TextAreaTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For;
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d378e8afa72f02363a75f2b6029f94a478ff5027295", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 42 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"buttons\">\r\n                <button type=\"submit\" class=\"button-1 send-pm-button\">");
#nullable restore
#line 47 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
                                                                 Write(T("PrivateMessages.Send.SendButton"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                <button type=\"button\" class=\"button-2 cancel-pm-button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2279, "\"", 2336, 3);
                WriteAttributeValue("", 2289, "setLocation(\'", 2289, 13, true);
#nullable restore
#line 48 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
WriteAttributeValue("", 2302, Url.RouteUrl("PrivateMessages"), 2302, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2334, "\')", 2334, 2, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 48 "D:\Projects\ProjectNop\Presentation\Nop.Web\Views\PrivateMessages\SendPM.cshtml"
                                                                                                                             Write(T("PrivateMessages.Send.CancelButton"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SendPrivateMessageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

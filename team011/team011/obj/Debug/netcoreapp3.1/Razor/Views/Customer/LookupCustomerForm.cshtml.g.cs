#pragma checksum "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/Customer/LookupCustomerForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72c59f4c8835e56a0d1625dc7c19af9ad92c89a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_LookupCustomerForm), @"mvc.1.0.view", @"/Views/Customer/LookupCustomerForm.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/_ViewImports.cshtml"
using team011;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/_ViewImports.cshtml"
using team011.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72c59f4c8835e56a0d1625dc7c19af9ad92c89a9", @"/Views/Customer/LookupCustomerForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6eceadba93b855566579e663d5cd9e6ca14d499", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_LookupCustomerForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("customerForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("customer "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/Customer/LookupCustomerForm.cshtml"
  
    Layout = "~/views/shared/_layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/Customer/LookupCustomerForm.cshtml"
Write(ViewBag.customer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container\">\n    <div>\n        <p>Customer ID: </p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72c59f4c8835e56a0d1625dc7c19af9ad92c89a94608", async() => {
                WriteLiteral(@"
            <div class=""form-group row"">
                <div class=""col-sm-10"" style=""display:inline-flex"">

                    <input type=""text"" id=""txtCustomerID"" placeholder=""Enter Customer ID Here"" class=""form-control"" />
                    <span class=""error"" style=""color:red; display:none"">*</span>

                </div>

                <div class=""col-sm-2"">
                    <input type=""button"" style=""bottom:0"" class=""btn btn-primary"" id=""btnsearchvehicle"" value=""Search"" />
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""row"">
                <div class=""col""></div>
                <div class=""col"">
                    <div class=""form-check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio1"" value=""option1"">
                        <label class=""form-check-label"" for=""inlineRadio1"">Individual</label>
                    </div>
                    <div class=""form-check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio2"" value=""option2"">
                        <label class=""form-check-label"" for=""inlineRadio2"">Business</label>
                    </div>
                </div>
                <div class=""col""></div>
            </div>
 

    </div>
    <a");
            BeginWriteAttribute("href", " href=\"", 1571, "\"", 1619, 1);
#nullable restore
#line 41 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/Customer/LookupCustomerForm.cshtml"
WriteAttributeValue("", 1578, Url.Action("AddCustomerForm","Customer"), 1578, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <input type=\"button\" class=\"btn btn-primary\" value=\"Add Customer\" />\n\n    </a>\n</div>\n<script>\n\n\n</script>");
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

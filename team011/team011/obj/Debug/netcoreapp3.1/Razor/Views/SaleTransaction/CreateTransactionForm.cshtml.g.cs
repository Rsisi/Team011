#pragma checksum "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/SaleTransaction/CreateTransactionForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4112ba07a3f23c469464d856a0dbd2fb1c717f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SaleTransaction_CreateTransactionForm), @"mvc.1.0.view", @"/Views/SaleTransaction/CreateTransactionForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4112ba07a3f23c469464d856a0dbd2fb1c717f4", @"/Views/SaleTransaction/CreateTransactionForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6eceadba93b855566579e663d5cd9e6ca14d499", @"/Views/_ViewImports.cshtml")]
    public class Views_SaleTransaction_CreateTransactionForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/SaleTransaction/CreateTransactionForm.cshtml"
  
    Layout = "~/views/shared/_layout.cshtml";
    var currentDate = (string)DateTime.Now.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">

    <ul class=""list-group list-group-flush"">

        <li class=""list-group-item"">
            <div class=""mx-auto font-weight-bold"" style=""width: 200px;"">
                Create Sales Order
            </div>
            <div class=""row"">
                <div class=""col text-center"">VIN</div>
                <div class=""col-7 text-left"">");
#nullable restore
#line 18 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/SaleTransaction/CreateTransactionForm.cshtml"
                                        Write(ViewBag.VIN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n            </div>\n        </li>\n        <li class=\"list-group-item\">\n            <div class=\"row\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 612, "\"", 663, 1);
#nullable restore
#line 24 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/SaleTransaction/CreateTransactionForm.cshtml"
WriteAttributeValue("", 619, Url.Action("LookupCustomerForm","Customer"), 619, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <input type=\"button\" class=\"btn btn-primary\" value=\"Look Up Customer\" />\n                </a>\n                <div class=\"col-8 text-center\">Customer Selected as: ");
#nullable restore
#line 27 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/SaleTransaction/CreateTransactionForm.cshtml"
                                                                Write(ViewBag.customer_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>


        </li>
        <li class=""list-group-item"">
            <div class=""form-group col-sm-4 "">
                <label>Sold Price </label>
                <input type=""number"" id=""txtSoldPrice"" placeholder=""Enter Sold Price Here"" class=""form-control"" min=""0"" />
            </div>
            <p>sold date: ");
#nullable restore
#line 37 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/SaleTransaction/CreateTransactionForm.cshtml"
                     Write(currentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <a");
            BeginWriteAttribute("href", " href=\"", 1239, "\"", 1305, 3);
#nullable restore
#line 38 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/SaleTransaction/CreateTransactionForm.cshtml"
WriteAttributeValue("", 1246, Url.Action("VehicleDetailForm","Vehicle"), 1246, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1288, "?VIN=", 1288, 5, true);
#nullable restore
#line 38 "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/SaleTransaction/CreateTransactionForm.cshtml"
WriteAttributeValue("", 1293, ViewBag.VIN, 1293, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <input type=\"button\" class=\"btn btn-primary\" value=\"Create Transaction\" />\n            </a>\n        </li>\n    </ul>\n </div>\n");
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

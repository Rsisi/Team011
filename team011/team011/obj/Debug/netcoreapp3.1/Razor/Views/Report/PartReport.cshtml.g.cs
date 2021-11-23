#pragma checksum "/Users/christineloveyy/Downloads/cs6400-2021-03-Team011 5reports done/team011/team011/Views/Report/PartReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e746d0ef45f5fd7931c82d2acab2fb7b586c88a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_PartReport), @"mvc.1.0.view", @"/Views/Report/PartReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e746d0ef45f5fd7931c82d2acab2fb7b586c88a", @"/Views/Report/PartReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6eceadba93b855566579e663d5cd9e6ca14d499", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_PartReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Report - Parts</h1>


<div class=""btn-group mt-3"">

        <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Get Reports
        </button>
        <div class=""dropdown-menu"">
            <a class=""dropdown-item"" href=""/Report/ColorReport"">Sales by Color</a>
            <a class=""dropdown-item"" href=""/Report/VehicleTypeReport"">Sales by Vehicle Type</a>
            <a class=""dropdown-item"" href=""/Report/ManufacturerReport"">Sales by Manufacturer</a>
            <a class=""dropdown-item"" href=""/Report/GrossCustomerIncomeReport"">Gross Customer Income</a>
            <a class=""dropdown-item"" href=""/Report/RepairReport"">Repair Reports</a>
            <a class=""dropdown-item"" href=""/Report/BelowCostSaleReport"">Below Cost Sales</a>
            <a class=""dropdown-item"" href=""/Report/AverageInventoryTimeReport"">View Average Inventory Time</a>
            <a class=""dropdown-item"" href=""/Report/PartReport"">Parts Statistics</a>
 ");
            WriteLiteral(@"           <a class=""dropdown-item"" href=""/Report/MonthlySaleReport"">Monthly Sales</a>
        </div>
    </div>



<div id=""tblunsoldVehicles"" style=""padding-top:5px"">
        <table id=""tblunsoldvehicles"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        Vendor
                    </th>
                    <th>
                        Number of Parts
                    </th>
                    <th>
                        Total Cost
                    </th>
                </tr>
            </thead>
            <tbody id=""unsoldvehicles"">
            </tbody>
        </table>

    </div>");
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
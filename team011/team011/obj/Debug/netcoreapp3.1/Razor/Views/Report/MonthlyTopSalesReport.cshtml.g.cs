#pragma checksum "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/MonthlyTopSalesReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd8ede60910bd4fdd38675873e1d2bdc73cc735f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_MonthlyTopSalesReport), @"mvc.1.0.view", @"/Views/Report/MonthlyTopSalesReport.cshtml")]
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
#line 1 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/_ViewImports.cshtml"
using team011;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/_ViewImports.cshtml"
using team011.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8ede60910bd4fdd38675873e1d2bdc73cc735f", @"/Views/Report/MonthlyTopSalesReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6eceadba93b855566579e663d5cd9e6ca14d499", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_MonthlyTopSalesReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/MonthlyTopSalesReport.cshtml"
  
    var monthTopReport = ViewBag.month_Top_report as List<MonthlyTopSalesReport>;
    string tempMonth = (ViewBag.TempMonth).toString();
    string tempYear = (ViewBag.TempYear).toString();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Report - Monthly Sales</h1>

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
        <a class=""dropdown-item"" href=""/Re");
            WriteLiteral("port/MonthlySaleReport\">Monthly Sales</a>\n    </div>\n</div>\n\n<a href=\"/Report/MonthlySaleReport\" class=\"btn btn-primary btn-lg active\" role=\"button\" aria-pressed=\"true\">Back to Repair by Mothly Sale Report</a>\n\n<h1>Detail for Top Sales in Year: ");
#nullable restore
#line 31 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/MonthlyTopSalesReport.cshtml"
                             Write(tempYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Month: ");
#nullable restore
#line 31 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/MonthlyTopSalesReport.cshtml"
                                              Write(tempMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<h2>Top Proforming Sales</h2>

<div id=""tblrepairbytype"" style=""padding-top:5px"">
    <table id=""tblrepairbytype"" class=""table table-striped table-bordered"" style=""width:100%"">
        <thead>
            <tr>
                <th>
                    Saler Name
                </th>
                <th>
                    Number of Sales
                </th>
                <th>
                    Total Income
                </th>
            </tr>
        </thead>
        <tbody id=""tblrepairbytype"">


");
#nullable restore
#line 52 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/MonthlyTopSalesReport.cshtml"
             foreach (var r in monthTopReport)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                       ");
#nullable restore
#line 57 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/MonthlyTopSalesReport.cshtml"
                  Write(r.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 58 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/MonthlyTopSalesReport.cshtml"
                   Write(r.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </td>\n\n                    <th>\n                        ");
#nullable restore
#line 63 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/MonthlyTopSalesReport.cshtml"
                   Write(r.totalVehicleSold);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <td>\n                        ");
#nullable restore
#line 66 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/MonthlyTopSalesReport.cshtml"
                   Write(r.SalesIncome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n    \n                </tr>\n");
#nullable restore
#line 70 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/MonthlyTopSalesReport.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n\n</div>\n");
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

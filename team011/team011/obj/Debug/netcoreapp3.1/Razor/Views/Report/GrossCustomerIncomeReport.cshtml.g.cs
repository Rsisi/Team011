#pragma checksum "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "963c4a4bf97c3967003f39ee65c6a162b7405e1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_GrossCustomerIncomeReport), @"mvc.1.0.view", @"/Views/Report/GrossCustomerIncomeReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"963c4a4bf97c3967003f39ee65c6a162b7405e1e", @"/Views/Report/GrossCustomerIncomeReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6eceadba93b855566579e663d5cd9e6ca14d499", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_GrossCustomerIncomeReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml"
  
    var report = ViewBag.GrossIncomeReport as List<GrossIncomeReport>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Report - Gross Customer Income(Top 15)</h1>


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
            <a class=""dropdown-item"" href=""/Report/PartReport");
            WriteLiteral(@""">Parts Statistics</a>
            <a class=""dropdown-item"" href=""/Report/MonthlySaleReport"">Monthly Sales</a>
        </div>
    </div>



<div id=""tblunsoldVehicles"" style=""padding-top:5px"">
   
        <table id=""tblunsoldvehicles"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        Customer Name
                    </th>
                    <th>
                        First Sale Date
                    </th>
                    <th>
                        Recent Action Date
                    </th>
                    <th>
                        Number of Sales
                    </th>

                    <th>
                        Number of Repairs
                    </th>
                    <th>
                        Gross Income
                    </th>
                   

                </tr>
            </thead>
            <tbody id=""unsoldvehicles"">
");
#nullable restore
#line 59 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml"
                 foreach (var r in report)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2356, "\"", 2424, 2);
            WriteAttributeValue("", 2363, "/Report/GrossOneCustomerIncomeReport?CustomerID=", 2363, 48, true);
#nullable restore
#line 64 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml"
WriteAttributeValue("", 2411, r.CustomerID, 2411, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                ");
#nullable restore
#line 65 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml"
                           Write(r.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </a>\n                      \n                        </td>\n                        <th>\n                            ");
#nullable restore
#line 70 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml"
                       Write(r.FirstServiceDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <td>\n                            ");
#nullable restore
#line 73 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml"
                       Write(r.LatestServiceDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 76 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml"
                       Write(r.NumOfRepair);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 79 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml"
                       Write(r.NumOfSale);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 82 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml"
                       Write(r.TotalIncome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        \n                    </tr>\n");
#nullable restore
#line 86 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Report/GrossCustomerIncomeReport.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n\n    </div>\n\n");
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

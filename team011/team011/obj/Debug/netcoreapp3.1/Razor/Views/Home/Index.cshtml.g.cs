#pragma checksum "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eac9e38757dda0b9d278a801ee4789a1df227ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 10 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eac9e38757dda0b9d278a801ee4789a1df227ff", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6eceadba93b855566579e663d5cd9e6ca14d499", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "feature", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "vin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("featureForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("feature"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("vinForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("vin "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    // var allColors = ViewData["allcolors"] as SelectList;
    var allColors = ViewBag.allcolors as SelectList;
    var allmanufacturer = ViewBag.allmanufacturer as SelectList;
    var allyear = ViewBag.allyear as SelectList;
    var alltypes = ViewBag.alltypes as SelectList;
    var allmodel = ViewBag.allmodel as SelectList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
<div class=""container"">
    <div>

        <div class=""form-group row "">


            <div class=""col-sm-6"">
                <label>  Search Vehicle By: </label>
                <select id=""ddlsearchmethod"" class=""form-control col-sm-5"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eac9e38757dda0b9d278a801ee4789a1df227ff6311", async() => {
                WriteLiteral("Features");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 24 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
                     if (@HttpContextAccessor.HttpContext.Session.GetString("loggedUserFullName") != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eac9e38757dda0b9d278a801ee4789a1df227ff7802", async() => {
                WriteLiteral("VIN");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 27 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </select>\n            </div>\n           \n\n            <div class=\"col-sm-4\">\n                <label style=\"display:block; bottom:0; right:0\">Vehicles In Stock: </label> ");
#nullable restore
#line 35 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
                                                                                       Write(ViewData["unsoldVehicles"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-sm-2\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 1252, "\"", 1298, 1);
#nullable restore
#line 38 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
WriteAttributeValue("", 1259, Url.Action("AddVehicleForm","Vehicle"), 1259, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <input type=\"button\" class=\"btn btn-primary\" value=\"Add Vehicle\" />\n\n                </a>\n\n            </div>\n        </div>\n\n        <div class=\"card card-body bg-light\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eac9e38757dda0b9d278a801ee4789a1df227ff10363", async() => {
                WriteLiteral(@"
                <div class=""form-group row"">
                    <div class=""col-sm-12"">
                        <label>Keywords: </label>
                        <input type=""text"" id=""txtkeyword"" placeholder=""Enter Keywords Here"" class=""form-control"" />

                    </div>

                </div>
                <div class=""form-group row"">
                    <div class=""col-sm-3"">
                        <label>Color:</label>
                        ");
#nullable restore
#line 59 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
                   Write(Html.DropDownList("ddlallColors", allColors, "Optional", htmlAttributes: new
                   {
                       name = "ddlallColors",
                       id = "ddlallColors",
                       @class = "form-control"

                   }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                    </div>\n\n                    <div class=\"col-sm-3\">\n                        <label>Manufacturer:</label>\n                        ");
#nullable restore
#line 71 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
                   Write(Html.DropDownList("ddlallmanufacturer", allmanufacturer, "Optional", htmlAttributes: new
                   {
                       name = "ddlallmanufacturer",
                       id = "ddlallmanufacturer",
                       @class = "form-control"

                   }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                    </div>\n                    <div class=\"col-sm-3\">\n                        <label>Vehicle Type:</label>\n                        ");
#nullable restore
#line 82 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
                   Write(Html.DropDownList("ddlalltypes", alltypes, "Optional", htmlAttributes: new
                   {
                       name = "ddlalltypes",
                       id = "ddlalltypes",
                       @class = "form-control"

                   }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n                    </div>\n                    <div class=\"col-sm-3\">\n                        <label>Vehicle Year:</label>\n                        ");
#nullable restore
#line 94 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
                   Write(Html.DropDownList("ddlallyear", allyear, "Optional", htmlAttributes: new
                   {
                       name = "ddlallyear",
                       id = "ddlallyear",
                       @class = "form-control"

                   }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                    </div>\n\n\n\n\n                </div>\n                <div class=\"form-group row\">\n                    <div class=\"col-sm-4\">\n                        <label>Vehicle Model:</label>\n                        ");
#nullable restore
#line 111 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
                   Write(Html.DropDownList("ddlallmodel", allmodel, "Optional", htmlAttributes: new
                   {
                       name = "ddlallmodel",
                       id = "ddlallmodel",
                       @class = "form-control"

                   }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                    </div>
                    <div class=""col-sm-4"">
                        <label>List Price(minimum):</label>
                        <div class=""input-group"">

                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">$</span>
                            </div>
                            <input type=""text"" placeholder=""0.00"" class=""form-control allow_decimal"">

                        </div>

                    </div>
                    <div class=""col-sm-4"">
                        <label>List Price(max):</label>
                        <div class=""input-group"">

                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">$</span>
                            </div>
                            <input type=""text"" placeholder=""0.00"" required class=""form-control allow_decimal"">


                        </div>

                    </div>

                </");
                WriteLiteral("div>\n\n\n\n\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eac9e38757dda0b9d278a801ee4789a1df227ff16484", async() => {
                WriteLiteral(@"
                <div class=""form-group row"">
                    <div class=""col-sm-12"">
                        <label>VIN: </label>
                        <input type=""text"" id=""txtvin"" placeholder=""Enter VIN Here"" class=""form-control"" />
                        <span class=""error"" style=""color:red; display:none"">*</span>

                    </div>

                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            <input type=""button"" class=""btn btn-primary"" id=""btnsearchvehicle"" value=""Search"" />


        </div>
        

    </div>
    <div id=""tblunsoldVehicles"" style=""padding-top:5px"">
        <table id=""tblunsoldvehicles"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        VIN
                    </th>
                    <th>
                        Vehicle Type
                    </th>
                    <th>
                        Model Year
                    </th>
                    <th>
                        Model Name
                    </th>
                    <th>
                        Manufacturer
                    </th>
                    <th>
                        Color
                    </th>
                    <th>
                        List Price
                    </th>
                    <th>
                        Description
                    </th>
       ");
            WriteLiteral(@"             <th></th>
                </tr>
            </thead>
            <tbody id=""unsoldvehicles"">
            </tbody>
        </table>

    </div>

</div>


<script>

    var searchMethod;
    unsoldTable = $('#tblunsoldvehicles').DataTable()
    $(document).ready(function () {
        $.noConflict();
        $(""#ddlsearchmethod"").change(function () {
            $(this).find(""option:selected"").each(function () {
                var optionValue = $(this).attr(""value"");
                searchMethod = optionValue;
                switch (optionValue) {
                    case ""feature"":
                        $('#featureForm').show();
                        $('#vinForm').hide();
                        break;
                    case ""vin"":
                        $('#featureForm').hide();
                        $('#vinForm').show();
                        break;
                    default:
                        $('#featureForm').show();
                        $('#vinForm').hide();
           ");
            WriteLiteral(@"     }



            });
        }).change();


        $('.allow_decimal').keypress(function (event) {
            return isNumber(event, this)
        });

        $('#btnsearchvehicle').on('click', function () {
            if (searchMethod == 'feature') {
                color = $('#ddlallColors :selected').val()
                manufacture = $('#ddlallmanufacturer :selected').val()
                type = $('#ddlalltypes :selected').val()
                year = $('#ddlallyear :selected').val()
                model = $('#ddlallmodel :selected').val()
                keyword = $('#txtkeyword').val()

                searchbyfeature(color, manufacture, type, year, model, keyword);


            }
            else {
                vin = $('#txtvin').val()
                console.log(vin)
                if (vin != null && vin !='') {
                    searchbyin(vin)
                    $('.error').hide()

                }
                else {
                    $('.error').show()
                }
 ");
            WriteLiteral(@"              
            }



        });



    });

    function isNumber(evt, element) {

        var charCode = (evt.which) ? evt.which : event.keyCode

        if (

            (charCode != 46 || $(element).val().indexOf('.') != -1) &&
            (charCode < 48 || charCode > 57))
            return false;

        return true;
    }

    function searchbyfeature(color, manufacture, type, year, model) {
        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 296 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
             Write(Url.Action("searchVehicleByFeature", "Vehicle"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {
                'color': color,
                'manufacture': manufacture,
                'type': type,
                'year': year,
                'model': model,
                'keyword': keyword
            },
            success: function (response) {
               
                if (unsoldTable != null) {
                    unsoldTable.destroy();
                    unsoldTable = $('#tblunsoldvehicles').DataTable({
                        data: response,
                        columns: [
                            { data: ""vin"" },
                            { data: ""vehicle_type"" },
                            { data: ""model_year"" },
                            { data: ""model_name"" },
                            { data: ""manufacturer_name"" },
                            { data: ""vehicle_color"" },
                            { data: ""list_price"" },
                            { data: ""description"" },
                            {
                                data: nul");
            WriteLiteral(@"l,
                                render: function (data, type, full, meta) {
                                    var VIN = full.vin;
                                    var detailURL = ""'"" + '/Vehicle/VehicleDetailForm?VIN=' + VIN + ""'"";
                                    var btnHtml = '<button class=""btn btn-primary  btn-sm"" onclick=""location.href=' + detailURL+'"">View Details</button>'
                                    return btnHtml
                                }

                               
                            }
                        ],
                        
                        language: {
                            ""zeroRecords"": ""Sorry, it looks like we don'thave that in stock!"",
                        }

                    })
                };



            },


        });
    }
    function searchbyin(vin) {
        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 350 "/Users/christineloveyy/Gatech/Pratice/GIT/Team011/team011/team011/Views/Home/Index.cshtml"
             Write(Url.Action("searchVehicleByVIN", "Vehicle"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {
                'vin': vin,
                
            },
            success: function (response) {
                console.log(response)

                if (unsoldTable != null) {
                    unsoldTable.destroy();
                    unsoldTable = $('#tblunsoldvehicles').DataTable({
                        data: response,
                        columns: [
                            { data: ""vin"" },
                            { data: ""vehicle_type"" },
                            { data: ""model_year"" },
                            { data: ""model_name"" },
                            { data: ""manufacturer_name"" },
                            { data: ""vehicle_color"" },
                            { data: ""list_price"" },
                            { data: ""description"" },
                            {
                                data: null,
                                render: function (data, type, full, meta) {
                                    var VIN = full.vin;
");
            WriteLiteral(@"                                    var detailURL = ""'"" + '/Vehicle/VehicleDetailForm?VIN=' + VIN + ""'"";
                                    var btnHtml = '<button class=""btn btn-primary  btn-sm"" onclick=""location.href=' + detailURL + '"">View Details</button>'
                                    return btnHtml
                                }


                            }
                        ],
                       
                     
                        ""language"": {
                            ""zeroRecords"": ""Sorry, it looks like we don'thave that in stock!"",
                        }

                    })
                };



            },


        });
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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

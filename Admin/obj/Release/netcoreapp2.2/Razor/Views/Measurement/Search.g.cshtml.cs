#pragma checksum "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f364255b9380f364e3721516d49ec937c150330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Measurement_Search), @"mvc.1.0.view", @"/Views/Measurement/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Measurement/Search.cshtml", typeof(AspNetCore.Views_Measurement_Search))]
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
#line 1 "C:\Theorem\SmartConditioning\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#line 2 "C:\Theorem\SmartConditioning\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#line 3 "C:\Theorem\SmartConditioning\Admin\Views\_ViewImports.cshtml"
using Admin.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f364255b9380f364e3721516d49ec937c150330", @"/Views/Measurement/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb5c0b94c991dd174eedad74622dc8c00f4a8cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Measurement_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MeasurementListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Search.cshtml"
  
    ViewData["Title"] = "Measurement";

#line default
#line hidden
            BeginContext(47, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(84, 66, true);
            WriteLiteral("\r\n<h3 class=\"display-4\">Measurements</h3>\r\n<input type=\"text\" />\r\n");
            EndContext();
            BeginContext(151, 113, false);
#line 10 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Search.cshtml"
Write(Html.ActionLink("Search", "Search", new { id = 12345 }, new { @class = "btn btn-light", @style = "color:black" }));

#line default
#line hidden
            EndContext();
            BeginContext(264, 463, true);
            WriteLiteral(@"

<br>

<div class=""row marginTop"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Device Serial Number</th>
                <th>Sensor Serial Number</th>
                <th>Measumerent DateTime</th>
                <th>Air Humidity</th>
                <th>Carbon Monoxide Level</th>
                <th>Health Status</th>
                <th>Temperature</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 28 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Search.cshtml"
             foreach (var measurement in Model.Measurements)
            {

#line default
#line hidden
            BeginContext(804, 80, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        &nbsp;\r\n");
            EndContext();
            BeginContext(943, 85, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        &nbsp;\r\n");
            EndContext();
            BeginContext(1087, 77, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1165, 42, false);
#line 40 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Search.cshtml"
                   Write(measurement.MeasumerentDateTime.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1207, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1287, 34, false);
#line 43 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Search.cshtml"
                   Write(measurement.AirHumidity.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1321, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1401, 42, false);
#line 46 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Search.cshtml"
                   Write(measurement.CarbonMonoxideLevel.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1443, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1523, 35, false);
#line 49 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Search.cshtml"
                   Write(measurement.HealthStatus.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1558, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1640, 34, false);
#line 53 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Search.cshtml"
                   Write(measurement.Temperature.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1674, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 56 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Search.cshtml"
            }

#line default
#line hidden
            BeginContext(1741, 45, true);
            WriteLiteral("        </tbody>\r\n        <table>\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MeasurementListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

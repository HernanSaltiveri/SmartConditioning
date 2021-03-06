#pragma checksum "C:\Theorem\SmartConditioning\Admin\Views\Sensor\SearchByDevice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73b7faa9220bc40bb4171eb5e52ba3802923f6c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sensor_SearchByDevice), @"mvc.1.0.view", @"/Views/Sensor/SearchByDevice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sensor/SearchByDevice.cshtml", typeof(AspNetCore.Views_Sensor_SearchByDevice))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73b7faa9220bc40bb4171eb5e52ba3802923f6c5", @"/Views/Sensor/SearchByDevice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb5c0b94c991dd174eedad74622dc8c00f4a8cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Sensor_SearchByDevice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SensorListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Theorem\SmartConditioning\Admin\Views\Sensor\SearchByDevice.cshtml"
  
    ViewData["Title"] = "Sensors";

#line default
#line hidden
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 38, true);
            WriteLiteral("\r\n<h3 class=\"display-4\">Sensors</h3>\r\n");
            EndContext();
            BeginContext(274, 284, true);
            WriteLiteral(@"
<br>


<div class=""row marginTop"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Device Serial Number</th>
                <th>Sensor Serial Number</th>
                <th>&nbsp;</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 24 "C:\Theorem\SmartConditioning\Admin\Views\Sensor\SearchByDevice.cshtml"
             foreach (var sensor in Model.Sensors)
            {

#line default
#line hidden
            BeginContext(625, 68, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    &nbsp;\r\n");
            EndContext();
            BeginContext(755, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 777, "\"", 858, 1);
#line 30 "C:\Theorem\SmartConditioning\Admin\Views\Sensor\SearchByDevice.cshtml"
WriteAttributeValue("", 784, Url.Action("Search", "Device" , new { id = sensor.Device.serialNumber  }), 784, 74, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(859, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(861, 37, false);
#line 30 "C:\Theorem\SmartConditioning\Admin\Views\Sensor\SearchByDevice.cshtml"
                                                                                                    Write(sensor.Device.serialNumber.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(898, 71, true);
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(970, 36, false);
#line 33 "C:\Theorem\SmartConditioning\Admin\Views\Sensor\SearchByDevice.cshtml"
               Write(sensor.sensorSerialNumber.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1006, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1075, "\"", 1168, 1);
#line 36 "C:\Theorem\SmartConditioning\Admin\Views\Sensor\SearchByDevice.cshtml"
WriteAttributeValue("", 1082, Url.Action("SearchBySensor", "Measurement" , new { id = sensor.sensorSerialNumber  }), 1082, 86, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1169, 63, true);
            WriteLiteral(">Measurements</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 40 "C:\Theorem\SmartConditioning\Admin\Views\Sensor\SearchByDevice.cshtml"
            }

#line default
#line hidden
            BeginContext(1247, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SensorListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

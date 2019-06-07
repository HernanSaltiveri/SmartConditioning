#pragma checksum "C:\Theorem\SmartConditioning\Admin\Views\Device\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31529b0e97444e4bd29549d41e0730ce5bde90c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_Search), @"mvc.1.0.view", @"/Views/Device/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Device/Search.cshtml", typeof(AspNetCore.Views_Device_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31529b0e97444e4bd29549d41e0730ce5bde90c6", @"/Views/Device/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb5c0b94c991dd174eedad74622dc8c00f4a8cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeviceListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Theorem\SmartConditioning\Admin\Views\Device\Search.cshtml"
  
    ViewData["Title"] = "Devices";

#line default
#line hidden
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 61, true);
            WriteLiteral("\r\n<h3 class=\"display-4\">Devices</h3>\r\n<input type=\"text\" />\r\n");
            EndContext();
            BeginContext(135, 113, false);
#line 9 "C:\Theorem\SmartConditioning\Admin\Views\Device\Search.cshtml"
Write(Html.ActionLink("Search", "Search", new { id =12345 },  new { @class = "btn btn-light", @style = "color:black" }));

#line default
#line hidden
            EndContext();
            BeginContext(248, 103, true);
            WriteLiteral("\r\n<br>\r\n\r\n\r\n<div class=\"row marginTop\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
            BeginContext(391, 214, true);
            WriteLiteral("                <th>Serial Number</th>\r\n                <th>FirmWare Version</th>\r\n                <th>Registration Date</th>\r\n                <th>&nbsp;</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 25 "C:\Theorem\SmartConditioning\Admin\Views\Device\Search.cshtml"
             foreach (var device in Model.Devices)
                {

#line default
#line hidden
            BeginContext(676, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
            BeginContext(776, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(819, 30, false);
#line 32 "C:\Theorem\SmartConditioning\Admin\Views\Device\Search.cshtml"
               Write(device.serialNumber.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(849, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(917, 33, false);
#line 35 "C:\Theorem\SmartConditioning\Admin\Views\Device\Search.cshtml"
               Write(device.firmWareVersion.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(950, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1018, 34, false);
#line 38 "C:\Theorem\SmartConditioning\Admin\Views\Device\Search.cshtml"
               Write(device.registrationDate.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1052, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1122, 69, false);
#line 42 "C:\Theorem\SmartConditioning\Admin\Views\Device\Search.cshtml"
               Write(Html.ActionLink("Sensors", "Sensor", "Search", new {  id = "12345" }));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 45 "C:\Theorem\SmartConditioning\Admin\Views\Device\Search.cshtml"
                }

#line default
#line hidden
            BeginContext(1254, 40, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeviceListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

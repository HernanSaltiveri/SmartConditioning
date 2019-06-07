#pragma checksum "C:\Theorem\SmartConditioning\Admin\Views\Device\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "360bb32141d1ceca686351223433e8d0b88e2a33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_Index), @"mvc.1.0.view", @"/Views/Device/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Device/Index.cshtml", typeof(AspNetCore.Views_Device_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"360bb32141d1ceca686351223433e8d0b88e2a33", @"/Views/Device/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb5c0b94c991dd174eedad74622dc8c00f4a8cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeviceListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Theorem\SmartConditioning\Admin\Views\Device\Index.cshtml"
  
    ViewData["Title"] = "Devices";

#line default
#line hidden
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 350, true);
            WriteLiteral(@"
<h3 class=""display-4"">Devices</h3>


<div class=""row marginTop"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Device Id</th>
                <th>FirmWare Version</th>
                <th>Serial Number</th>
                <th>Registration Date</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Theorem\SmartConditioning\Admin\Views\Device\Index.cshtml"
         foreach (var device in Model.Devices)
        {

#line default
#line hidden
            BeginContext(482, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(543, 26, false);
#line 25 "C:\Theorem\SmartConditioning\Admin\Views\Device\Index.cshtml"
               Write(device.DeviceId.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(569, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(637, 33, false);
#line 28 "C:\Theorem\SmartConditioning\Admin\Views\Device\Index.cshtml"
               Write(device.firmWareVersion.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(670, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(738, 30, false);
#line 31 "C:\Theorem\SmartConditioning\Admin\Views\Device\Index.cshtml"
               Write(device.serialNumber.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(768, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(836, 34, false);
#line 34 "C:\Theorem\SmartConditioning\Admin\Views\Device\Index.cshtml"
               Write(device.registrationDate.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(870, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "C:\Theorem\SmartConditioning\Admin\Views\Device\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(925, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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

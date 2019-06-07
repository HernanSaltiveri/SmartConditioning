#pragma checksum "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae7715f39f4ae4dc3e78962e441374deb32c3f39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Measurement_Index), @"mvc.1.0.view", @"/Views/Measurement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Measurement/Index.cshtml", typeof(AspNetCore.Views_Measurement_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae7715f39f4ae4dc3e78962e441374deb32c3f39", @"/Views/Measurement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb5c0b94c991dd174eedad74622dc8c00f4a8cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Measurement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MeasurementListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml"
  
    ViewData["Title"] = "Measurement";

#line default
#line hidden
            BeginContext(47, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(84, 269, true);
            WriteLiteral(@"
<h3 class=""display-4"">Measurements</h3>

<div class=""row marginTop"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Device Id</th>
                <th>FirmWare Version</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml"
             foreach (var measurement in Model.Measurements)
            {

#line default
#line hidden
            BeginContext(430, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(503, 34, false);
#line 23 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml"
                   Write(measurement.AirHumidity.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(537, 80, true);
            WriteLiteral(";\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(618, 42, false);
#line 26 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml"
                   Write(measurement.CarbonMonoxideLevel.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(660, 53, true);
            WriteLiteral(";\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 29 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(728, 41, true);
            WriteLiteral("        </tbody>\r\n    <table>\r\n\r\n</div>\r\n");
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

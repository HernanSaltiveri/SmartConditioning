#pragma checksum "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e166c4442927be9e650fd9d80a49335142a3f41"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e166c4442927be9e650fd9d80a49335142a3f41", @"/Views/Measurement/Index.cshtml")]
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
            BeginContext(84, 76, true);
            WriteLiteral("\r\n<h3 class=\"display-4\">Measurements</h3>\r\n\r\n<div class=\"row marginTop\">\r\n\r\n");
            EndContext();
#line 12 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml"
     foreach (var measurement in Model.Measurements)
    {

#line default
#line hidden
            BeginContext(221, 48, true);
            WriteLiteral("        <ul>\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(270, 34, false);
#line 16 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml"
           Write(measurement.AirHumidity.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(304, 56, true);
            WriteLiteral(";\r\n            </li>\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(361, 42, false);
#line 19 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml"
           Write(measurement.CarbonMonoxideLevel.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(403, 37, true);
            WriteLiteral(";\r\n            </li>\r\n        </ul>\r\n");
            EndContext();
#line 22 "C:\Theorem\SmartConditioning\Admin\Views\Measurement\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(447, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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

#pragma checksum "C:\ASP.NET Training\FirstMVCPrj\FirstMVCPrj\FirstMVCPrj\Views\Home\Sample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60d81a2d15e69b7b68a128b47b0d1f52c0561338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sample), @"mvc.1.0.view", @"/Views/Home/Sample.cshtml")]
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
#line 1 "C:\ASP.NET Training\FirstMVCPrj\FirstMVCPrj\FirstMVCPrj\Views\_ViewImports.cshtml"
using FirstMVCPrj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ASP.NET Training\FirstMVCPrj\FirstMVCPrj\FirstMVCPrj\Views\_ViewImports.cshtml"
using FirstMVCPrj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d81a2d15e69b7b68a128b47b0d1f52c0561338", @"/Views/Home/Sample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f54b1338a02027d1376ed9aff7ed33f7851601d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sample : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\ASP.NET Training\FirstMVCPrj\FirstMVCPrj\FirstMVCPrj\Views\Home\Sample.cshtml"
  
    ViewBag.cshtmlBag= "Welcome to Shivani's Page";
    ViewBag.getBag= "\"" + ViewBag.cshtmlBag + "\"";
    ViewBag.putBag = "\"" + ViewBag.getBag + "\"";
    ViewData["cshtmlData"]= 34;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>helo</h1>\r\n            <h1>THis is the sample of ");
#nullable restore
#line 11 "C:\ASP.NET Training\FirstMVCPrj\FirstMVCPrj\FirstMVCPrj\Views\Home\Sample.cshtml"
                                 Write(ViewData["textData"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>This is another sample of ");
#nullable restore
#line 12 "C:\ASP.NET Training\FirstMVCPrj\FirstMVCPrj\FirstMVCPrj\Views\Home\Sample.cshtml"
                             Write(ViewBag.Bag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <h1>Writing inside cshtml   ");
#nullable restore
#line 14 "C:\ASP.NET Training\FirstMVCPrj\FirstMVCPrj\FirstMVCPrj\Views\Home\Sample.cshtml"
                           Write(ViewBag.putBag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <h1>Writing inside cshtml for data ");
#nullable restore
#line 16 "C:\ASP.NET Training\FirstMVCPrj\FirstMVCPrj\FirstMVCPrj\Views\Home\Sample.cshtml"
                                  Write(ViewData["cshtmlData"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n        <hr>\r\n");
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

#pragma checksum "C:\Users\Vlad\source\repos\Vote\Vote\Views\Vote\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76126d80b5e8771e5eb0219c45109a29d55f505e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vote_Privacy), @"mvc.1.0.view", @"/Views/Vote/Privacy.cshtml")]
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
#line 1 "C:\Users\Vlad\source\repos\Vote\Vote\Views\_ViewImports.cshtml"
using Vote;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76126d80b5e8771e5eb0219c45109a29d55f505e", @"/Views/Vote/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b593508bc18a47ebd5b297590b3b55eae8a98992", @"/Views/_ViewImports.cshtml")]
    public class Views_Vote_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 2 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Vote\Privacy.cshtml"
Write(Localizer["p0"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 5 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Vote\Privacy.cshtml"
Write(Localizer["p1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    ");
#nullable restore
#line 6 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Vote\Privacy.cshtml"
Write(Localizer["p2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    ");
#nullable restore
#line 7 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Vote\Privacy.cshtml"
Write(Localizer["p3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong>");
#nullable restore
#line 7 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Vote\Privacy.cshtml"
                        Write(Localizer["p4"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>.\r\n</p>\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Vote\Privacy.cshtml"
Write(Localizer["p6"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<div style=\"display: flex; flex-direction: column\">\r\n");
#nullable restore
#line 13 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Vote\Privacy.cshtml"
     foreach (var email in ViewBag.emails)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>");
#nullable restore
#line 15 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Vote\Privacy.cshtml"
        Write(email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Vote\Privacy.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer Localizer { get; private set; }
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

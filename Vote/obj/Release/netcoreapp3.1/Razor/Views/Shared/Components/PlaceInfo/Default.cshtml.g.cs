#pragma checksum "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8be71be331585f8cd33c7e69c4f8d19c9f1df23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PlaceInfo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PlaceInfo/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8be71be331585f8cd33c7e69c4f8d19c9f1df23", @"/Views/Shared/Components/PlaceInfo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b593508bc18a47ebd5b297590b3b55eae8a98992", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PlaceInfo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"info__title\">\r\n    ");
#nullable restore
#line 5 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
Write(Localizer["Info"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"info__property info__property_main\">\r\n    ");
#nullable restore
#line 8 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
Write(Localizer["Voted"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
                   Write(ViewBag.TotalVotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"info__property info__property_main\">\r\n    ");
#nullable restore
#line 11 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
Write(Localizer["Evidences"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
                       Write(ViewBag.TotalEvidences);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"info__property\">\r\n    ");
#nullable restore
#line 14 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
Write(Localizer["Region"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
                    Write(ViewBag.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"info__property\">\r\n    ");
#nullable restore
#line 17 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
Write(Localizer["Town"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
                  Write(ViewBag.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"info__property\">\r\n    ");
#nullable restore
#line 20 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
Write(Localizer["Street"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
                    Write(ViewBag.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"info__property\">\r\n    ");
#nullable restore
#line 23 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
Write(Localizer["Number"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
                    Write(ViewBag.House);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
 if (ViewBag.showDetail)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=", 707, "", 766, 1);
#nullable restore
#line 28 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
WriteAttributeValue("", 713, Url.Action("PlaceDetail", "Map" , new {@ViewBag.Id}), 713, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
                                                             Write(Localizer["Detail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 29 "C:\Users\Vlad\source\repos\Vote\Vote\Views\Shared\Components\PlaceInfo\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
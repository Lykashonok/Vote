#pragma checksum "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f82bc384f545f283ad2924c667404492c7262575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Admin_Users), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Admin/Users.cshtml")]
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
#line 1 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Vote;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f82bc384f545f283ad2924c667404492c7262575", @"/Areas/AdminPanel/Views/Admin/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c026cfc711da85e5c173a4a83de215d7a7a3d2", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Admin_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vote.Areas.AdminPanel.Forms.AdminPanelUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/table.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f82bc384f545f283ad2924c667404492c72625753728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"vote__table\">\r\n    <tr class=\"table__header\">\r\n        <th class=\"prop__title\">");
#nullable restore
#line 7 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                           Write(Localizer["Mail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th class=\"prop__title\">");
#nullable restore
#line 8 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                           Write(Localizer["Confirm"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th class=\"prop__title\">");
#nullable restore
#line 9 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                           Write(Localizer["Phone"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th class=\"prop__title\">");
#nullable restore
#line 10 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                           Write(Localizer["Try"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th class=\"prop__title\">");
#nullable restore
#line 11 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                           Write(Localizer["Id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th class=\"prop__title\">");
#nullable restore
#line 12 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                           Write(Localizer["Actions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
     for (int i = 0; i < Model.Count(); i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table__user\">\r\n            <td class=\"prop\">\r\n");
#nullable restore
#line 18 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                 if (!Model[i].Roles.Contains("SuperAdmin") || User.IsInRole("SuperAdmin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=", 851, "", 917, 1);
#nullable restore
#line 20 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 857, Url.Action("UserDetail", "Admin", new { Id = Model[i].Id }), 857, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                    Write(Model[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 21 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
               Write(Model[i].Email);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                   
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td class=\"prop\">");
#nullable restore
#line 27 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                        Write(Model[i].EmailConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"prop\">");
#nullable restore
#line 28 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                        Write(Model[i].Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"prop\">");
#nullable restore
#line 29 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                        Write(Model[i].AccessFailedCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"prop\">");
#nullable restore
#line 30 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                        Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"prop\">\r\n");
#nullable restore
#line 32 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                 if (!Model[i].Roles.Contains("SuperAdmin") || User.IsInRole("SuperAdmin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=", 1461, "", 1527, 1);
#nullable restore
#line 34 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 1467, Url.Action("UserDetail", "Admin", new { Id = Model[i].Id }), 1467, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                    Write(Localizer["Detail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small>,</small>\r\n");
#nullable restore
#line 35 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                 if (User.IsInRole("SuperAdmin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=", 1681, "", 1747, 1);
#nullable restore
#line 38 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 1687, Url.Action("UserDelete", "Admin", new { Id = Model[i].Id }), 1687, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                    Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small>,</small>\r\n");
#nullable restore
#line 39 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                     if (!Model[i].Roles.Contains("Manager"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=", 1902, "", 1987, 1);
#nullable restore
#line 41 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 1908, Url.Action("UserRoleSet", "Admin", new { Id = Model[i].Id, Role = "Manager" }), 1908, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                                           Write(Localizer["MakeManager"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small>,</small>\r\n");
#nullable restore
#line 42 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=", 2133, "", 2220, 1);
#nullable restore
#line 45 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 2139, Url.Action("UserRoleUnset", "Admin", new { Id = Model[i].Id, Role = "Manager" }), 2139, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                                             Write(Localizer["UnMakeManager"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small>,</small>\r\n");
#nullable restore
#line 46 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                     if (!Model[i].Roles.Contains("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=", 2403, "", 2486, 1);
#nullable restore
#line 49 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 2409, Url.Action("UserRoleSet", "Admin", new { Id = Model[i].Id, Role = "Admin" }), 2409, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                                         Write(Localizer["MakeAdmin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small>,</small>\r\n");
#nullable restore
#line 50 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=", 2630, "", 2715, 1);
#nullable restore
#line 53 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 2636, Url.Action("UserRoleUnset", "Admin", new { Id = Model[i].Id, Role = "Admin" }), 2636, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                                           Write(Localizer["UnMakeAdmin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small>,</small>\r\n");
#nullable restore
#line 54 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                     
                }
                else if (User.IsInRole("Admin"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                     if (!Model[i].Roles.Contains("SuperAdmin"))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                         if (!Model[i].Roles.Contains("Manager"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=", 3087, "", 3172, 1);
#nullable restore
#line 62 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 3093, Url.Action("UserRoleSet", "Admin", new { Id = Model[i].Id, Role = "Manager" }), 3093, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                                               Write(Localizer["Подробнее"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small>,</small>\r\n");
#nullable restore
#line 63 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=", 3332, "", 3419, 1);
#nullable restore
#line 66 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 3338, Url.Action("UserRoleUnset", "Admin", new { Id = Model[i].Id, Role = "Manager" }), 3338, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                                                 Write(Localizer["UnMakeManager"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small>,</small>\r\n");
#nullable restore
#line 67 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                         if (!Model[i].Roles.Contains("Admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=", 3618, "", 3701, 1);
#nullable restore
#line 70 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 3624, Url.Action("UserRoleSet", "Admin", new { Id = Model[i].Id, Role = "Admin" }), 3624, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                                             Write(Localizer["MakeAdmin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small>,</small>\r\n");
#nullable restore
#line 71 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=", 3861, "", 3946, 1);
#nullable restore
#line 74 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
WriteAttributeValue("", 3867, Url.Action("UserRoleUnset", "Admin", new { Id = Model[i].Id, Role = "Admin" }), 3867, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                                                                                                               Write(Localizer["UnMakeAdmin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small>,</small>\r\n");
#nullable restore
#line 75 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 80 "C:\Users\Vlad\source\repos\Vote\Vote\Areas\AdminPanel\Views\Admin\Users.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vote.Areas.AdminPanel.Forms.AdminPanelUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591

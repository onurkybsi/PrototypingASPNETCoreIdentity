#pragma checksum "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0757701a04ede7f222ee863ab4289ffa256216d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\_ViewImports.cshtml"
using PrototypingASPNETCoreIdentity.Models;

#line default
#line hidden
#line 2 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\_ViewImports.cshtml"
using PrototypingASPNETCoreIdentity.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0757701a04ede7f222ee863ab4289ffa256216d", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e6253e0442c240212f22d695ae2b5c32e8c1225", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ui button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:20px; height: 100%; overflow: hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\Admin\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(58, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(87, 399, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0757701a04ede7f222ee863ab4289ffa256216d4973", async() => {
                BeginContext(93, 386, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <script src=""https://code.jquery.com/jquery-3.1.1.min.js"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/semantic-ui@2.4.2/dist/semantic.min.css"">
    <script src=""https://cdn.jsdelivr.net/npm/semantic-ui@2.4.2/dist/semantic.min.js""></script>
    <title>Admin</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(486, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(488, 1156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0757701a04ede7f222ee863ab4289ffa256216d6553", async() => {
                BeginContext(546, 194, true);
                WriteLiteral("\r\n    <div class=\"ui segment\">\r\n        <h2 class=\"ui center aligned header\">\r\n            <div class=\"content\">\r\n                User Accounts\r\n            </div>\r\n        </h2>\r\n    </div>\r\n\r\n");
                EndContext();
#line 26 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\Admin\Index.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
                BeginContext(777, 140, true);
                WriteLiteral("        <div class=\"ui warning message\" style=\"width:50%; margin:0 auto; text-align:center\">\r\n            No User Accounts\r\n        </div>\r\n");
                EndContext();
#line 31 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\Admin\Index.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(941, 293, true);
                WriteLiteral(@"        <table class=""ui selectable inverted table"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Username</th>
                    <th class=""right aligned"">Email</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 43 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\Admin\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(1299, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(1354, 7, false);
#line 46 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\Admin\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1361, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1397, 13, false);
#line 47 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\Admin\Index.cshtml"
                       Write(item.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1410, 57, true);
                WriteLiteral("</td>\r\n                        <td class=\"right aligned\">");
                EndContext();
                BeginContext(1468, 10, false);
#line 48 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\Admin\Index.cshtml"
                                             Write(item.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1478, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 50 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1531, 40, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n");
                EndContext();
#line 53 "C:\Users\onurb\Source\Repos\PrototypingASPNETCoreIdentity\PrototypingASPNETCoreIdentity\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(1578, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1584, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0757701a04ede7f222ee863ab4289ffa256216d10533", async() => {
                    BeginContext(1625, 6, true);
                    WriteLiteral("Create");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1635, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1644, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591

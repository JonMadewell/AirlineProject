#pragma checksum "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d137e8a6c909a5e321b70a0e722edca982e48b85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plane_Index), @"mvc.1.0.view", @"/Views/Plane/Index.cshtml")]
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
#line 1 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\_ViewImports.cshtml"
using AirlineProject.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\_ViewImports.cshtml"
using AirlineProject.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d137e8a6c909a5e321b70a0e722edca982e48b85", @"/Views/Plane/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cedea4ecf33d0fc7f1e9d88f7536e35126ef67f", @"/Views/_ViewImports.cshtml")]
    public class Views_Plane_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AirlineProject.Data.Plane>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Plane", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: linear-gradient(135deg, #9b76d7 10%, #0f12b7 100%)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml"
  
    ViewData["Title"] = "Planes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<html style=\"height: 100%\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d137e8a6c909a5e321b70a0e722edca982e48b855274", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h1 class=\"text-light\">Our Fleet</h1>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d137e8a6c909a5e321b70a0e722edca982e48b855604", async() => {
                    WriteLiteral("New Plane");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <table class=\"table table-hover text-light\">\r\n            <thead>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 16 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 17 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 18 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.capacity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Detalis</td>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 24 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml"
                 foreach (var plane in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 27 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml"
                       Write(Html.DisplayFor(modelitem => plane.id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml"
                       Write(Html.DisplayFor(modelitem => plane.name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml"
                       Write(Html.DisplayFor(modelitem => plane.capacity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                        <td>");
#nullable restore
#line 31 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { id = plane.id }, new { style = "color: white" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 34 "D:\Skillstorm\Projects\AirlineProject\AirlineProject.Web\AirlineProject.Web\Views\Plane\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AirlineProject.Data.Plane>> Html { get; private set; }
    }
}
#pragma warning restore 1591

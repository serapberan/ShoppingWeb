#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\UILayoutPartial\_NavbarTopPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1205bb4e8f78a868b67056084e3881fd65643d69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UILayoutPartial__NavbarTopPartial), @"mvc.1.0.view", @"/Views/UILayoutPartial/_NavbarTopPartial.cshtml")]
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
#line 1 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\_ViewImports.cshtml"
using ETicaretShooping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\_ViewImports.cshtml"
using ETicaretShooping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1205bb4e8f78a868b67056084e3881fd65643d69", @"/Views/UILayoutPartial/_NavbarTopPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ad6d06a4c71770f3cf2b670355c7b522b12ae9", @"/Views/_ViewImports.cshtml")]
    public class Views_UILayoutPartial__NavbarTopPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row bg-secondary py-2 px-xl-5\">\r\n        <div class=\"col-lg-6 d-none d-lg-block\">\r\n            <div class=\"d-inline-flex align-items-center\">\r\n                <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 257, "\"", 264, 0);
            EndWriteAttribute();
            WriteLiteral(">FAQs</a>\r\n                <span class=\"text-muted px-2\">|</span>\r\n                <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 368, "\"", 375, 0);
            EndWriteAttribute();
            WriteLiteral(">Help</a>\r\n                <span class=\"text-muted px-2\">|</span>\r\n                <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 479, "\"", 486, 0);
            EndWriteAttribute();
            WriteLiteral(">Support</a>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-6 text-center text-lg-right\">\r\n            <div class=\"d-inline-flex align-items-center\">\r\n                <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 696, "\"", 703, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fab fa-facebook-f\"></i>\r\n                </a>\r\n                <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 825, "\"", 832, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fab fa-twitter\"></i>\r\n                </a>\r\n                <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 951, "\"", 958, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fab fa-linkedin-in\"></i>\r\n                </a>\r\n                <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 1081, "\"", 1088, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fab fa-instagram\"></i>\r\n                </a>\r\n                <a class=\"text-dark pl-2\"");
            BeginWriteAttribute("href", " href=\"", 1209, "\"", 1216, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fab fa-youtube\"></i>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row align-items-center py-3 px-xl-5\">\r\n        <div class=\"col-lg-3 d-none d-lg-block\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1461, "\"", 1468, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""text-decoration-none"">
                <h1 class=""m-0 display-5 font-weight-semi-bold""><span class=""text-primary font-weight-bold border px-3 mr-1"">E</span>Shopper</h1>
            </a>
        </div>
        <div class=""col-lg-6 col-6 text-left"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1205bb4e8f78a868b67056084e3881fd65643d696711", async() => {
                WriteLiteral(@"
                <div class=""input-group"">
                    <input type=""text"" class=""form-control"" placeholder=""Aranacak Ürün"">
                    <div class=""input-group-append"">
                        <span class=""input-group-text bg-transparent text-primary"">
                            <i class=""fa fa-search""></i>
                        </span>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-3 col-6 text-right\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2275, "\"", 2282, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn border\">\r\n                <i class=\"fas fa-heart text-primary\"></i>\r\n                <span class=\"badge\">0</span>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2442, "\"", 2449, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn border\">\r\n                <i class=\"fas fa-shopping-cart text-primary\"></i>\r\n                <span class=\"badge\">0</span>\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>");
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

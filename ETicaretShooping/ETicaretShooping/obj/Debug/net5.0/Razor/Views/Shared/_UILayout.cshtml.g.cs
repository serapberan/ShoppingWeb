#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UILayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38eab98f1092a45dec5006bd9980c3bbaef19907"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UILayout), @"mvc.1.0.view", @"/Views/Shared/_UILayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38eab98f1092a45dec5006bd9980c3bbaef19907", @"/Views/Shared/_UILayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ad6d06a4c71770f3cf2b670355c7b522b12ae9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UILayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UILayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n\r\n    ");
#nullable restore
#line 11 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/UILayoutPartial/_HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38eab98f1092a45dec5006bd9980c3bbaef199073712", async() => {
                WriteLiteral("\r\n    <!-- Topbar Start -->\r\n    ");
#nullable restore
#line 14 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/UILayoutPartial/_NavbarTopPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- Topbar End -->\r\n    <!-- Navbar Start -->\r\n    <div class=\"container-fluid mb-5\">\r\n        <div class=\"row border-top px-xl-5\">\r\n            <!--  <h1>Menü bar start </h1> start-->\r\n            ");
#nullable restore
#line 20 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UILayout.cshtml"
       Write(await Html.PartialAsync("/Views/UILayoutPartial/_MenuPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <!--  <h1>Menü bar </h1> end-->\r\n            <!-- Navbar login kısmı sekmeler start-->\r\n            ");
#nullable restore
#line 23 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UILayout.cshtml"
       Write(await Html.PartialAsync("/Views/UILayoutPartial/_NavbarDownPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <!-- Navbar login kısmı sekmeler end-->\r\n            <!-- iconlar -->\r\n            ");
#nullable restore
#line 26 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UILayout.cshtml"
       Write(await Html.PartialAsync("/Views/UILayoutPartial/_IconPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <!-- Navbar End -->\r\n  \r\n\r\n    ");
#nullable restore
#line 32 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UILayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- Footer Start -->\r\n    ");
#nullable restore
#line 35 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/UILayoutPartial/_FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- Footer End -->\r\n    <!-- Back to Top -->\r\n    <a href=\"#\" class=\"btn btn-primary back-to-top\"><i class=\"fa fa-angle-double-up\"></i></a>\r\n\r\n    ");
#nullable restore
#line 40 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/UILayoutPartial/_ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n\r\n");
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
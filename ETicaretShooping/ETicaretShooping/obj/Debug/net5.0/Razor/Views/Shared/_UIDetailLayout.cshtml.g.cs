#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "287f2524038ef8967a7dce9cb19ea023eb8804f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UIDetailLayout), @"mvc.1.0.view", @"/Views/Shared/_UIDetailLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"287f2524038ef8967a7dce9cb19ea023eb8804f3", @"/Views/Shared/_UIDetailLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ce84a101de21b3e2304fcaba45e4fc00284ab2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UIDetailLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
Write(await Html.PartialAsync("/Views/UILayoutPartial/_HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287f2524038ef8967a7dce9cb19ea023eb8804f33745", async() => {
                WriteLiteral("\r\n    <!-- Topbar Start -->\r\n    ");
#nullable restore
#line 13 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
Write(await Html.PartialAsync("/Views/UILayoutPartial/_NavbarTopPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- Topbar End -->
    <!-- Navbar Start -->
    <div class=""container-fluid"">
        <div class=""row border-top px-xl-5"">
            <div class=""col-lg-3 d-none d-lg-block"">
                <a class=""btn shadow-none d-flex align-items-center justify-content-between bg-primary text-white w-100"" data-toggle=""collapse"" href=""#navbar-vertical"" style=""height: 65px; margin-top: -1px; padding: 0 30px;"">
                    <h6 class=""m-0"">KATEGOR??LER</h6>
                    <i class=""fa fa-angle-down text-dark""></i>
                </a>
                <nav class=""collapse position-absolute navbar navbar-vertical navbar-light align-items-start p-0 border border-top-0 border-bottom-0 bg-light"" id=""navbar-vertical"" style=""width: calc(100% - 30px); z-index: 1;"">
                    <div class=""navbar-nav w-100 overflow-hidden"" style=""height: 410px"">
                        <div class=""nav-item dropdown"">
                            <a href=""#"" class=""nav-link"" data-toggle=""dropdown"">Koleksiyonlar");
                WriteLiteral(" <i class=\"fa fa-angle-down float-right mt-1\"></i></a>\r\n                            <div class=\"dropdown-menu position-absolute bg-secondary border-0 rounded-0 w-100 m-0\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1489, "\"", 1496, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"dropdown-item\">Kad??n Giyim</a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1571, "\"", 1578, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"dropdown-item\">Erkek Giyim</a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1653, "\"", 1660, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"dropdown-item\">??ocuk Giyim</a>\r\n                            </div>\r\n                        </div>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1795, "\"", 1802, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">TShirts & Bluz</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1876, "\"", 1883, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">Sweatshirt</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1953, "\"", 1960, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">G??mlek</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2026, "\"", 2033, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">H??rka</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2098, "\"", 2105, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">Pantolon</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2173, "\"", 2180, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">Jean</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2244, "\"", 2251, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">Elbise</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2317, "\"", 2324, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">Ceket</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2389, "\"", 2396, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">Kaban</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2461, "\"", 2468, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""nav-item nav-link"">Mont</a>
                    </div>
                </nav>
            </div>
            <div class=""col-lg-9"">
                <nav class=""navbar navbar-expand-lg bg-light navbar-light py-3 py-lg-0 px-0"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 2731, "\"", 2738, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none d-block d-lg-none"">
                        <h1 class=""m-0 display-5 font-weight-semi-bold""><span class=""text-primary font-weight-bold border px-3 mr-1"">E</span>Shopper</h1>
                    </a>
                    <button type=""button"" class=""navbar-toggler"" data-toggle=""collapse"" data-target=""#navbarCollapse"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse justify-content-between"" id=""navbarCollapse"">
                        <div class=""navbar-nav mr-auto py-0"">
                            <a href=""/Anasayfa/Index"" class=""nav-item nav-link"">Anasayfa</a>
                            <a href=""/Product/List"" class=""nav-item nav-link"">??r??nler</a>
                            <a href=""detail.html"" class=""nav-item nav-link active"">Sepetim</a>
");
                WriteLiteral("                            <a href=\"contact.html\" class=\"nav-item nav-link\">??leti??im</a>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 69 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"nav-item dropdown\">\r\n                                <a href=\"#\" class=\"nav-link dropdown-toggle\" data-toggle=\"dropdown\"> Merhaba ");
#nullable restore
#line 72 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
                                                                                                        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                <div class=\"dropdown-menu rounded-0 m-0\">\r\n");
#nullable restore
#line 74 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
                                     if (User.HasClaim(x => x.Value == "Admin"))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a href=\"/Admin/Profile/Index\" class=\"dropdown-item\">Kullan??c?? Paneline Git</a>\r\n");
#nullable restore
#line 77 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a href=\"/Member/Profile/Index\" class=\"dropdown-item\">Kullan??c?? Paneline Git</a>\r\n");
#nullable restore
#line 81 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    <a href=\"/Login/LogOut/\" class=\"dropdown-item\">????k???? Yap</a>\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 87 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""navbar-nav ml-auto py-0"">
                                <a href=""/Login/SignIn/"" class=""nav-item nav-link"">??ye Giri??i</a>
                                <a href=""/Login/SignUp/"" class=""nav-item nav-link"">??ye Ol</a>
                            </div>
");
#nullable restore
#line 95 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                   \r\n                    </div>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Navbar End -->\r\n\r\n\r\n    ");
#nullable restore
#line 105 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- Footer Start -->\r\n    ");
#nullable restore
#line 108 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
Write(await Html.PartialAsync("/Views/UILayoutPartial/_FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- Footer End -->\r\n    <!-- Back to Top -->\r\n    <a href=\"#\" class=\"btn btn-primary back-to-top\"><i class=\"fa fa-angle-double-up\"></i></a>\r\n\r\n    ");
#nullable restore
#line 114 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\_UIDetailLayout.cshtml"
Write(await Html.PartialAsync("/Views/UILayoutPartial/_ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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

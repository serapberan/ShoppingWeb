#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_ProductComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45dbc99f3c42448bda36476cecee71bb1349d98a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ProductComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_ProductComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45dbc99f3c42448bda36476cecee71bb1349d98a", @"/Views/Shared/Components/_ProductComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ce84a101de21b3e2304fcaba45e4fc00284ab2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__ProductComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Concrete.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container-fluid pt-5\">\r\n    <div class=\"text-center mb-4\">\r\n        <h2 class=\"section-title px-5\"><span class=\"px-2\">En Çok Satılanlar</span></h2>\r\n    </div>\r\n    <div class=\"row px-xl-5 pb-3\">\r\n");
#nullable restore
#line 10 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_ProductComponent\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-3 col-md-6 col-sm-12 pb-1"">

                <div class=""card product-item border-0 mb-4"">
                    <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45dbc99f3c42448bda36476cecee71bb1349d98a4820", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 645, "~/images/productimages/", 645, 23, true);
#nullable restore
#line 16 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_ProductComponent\Default.cshtml"
AddHtmlAttributeValue("", 668, item.ImageUrl, 668, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-body border-left border-right text-center p-0 pt-4 pb-3\">\r\n                        <h6 class=\"text-truncate mb-3\">");
#nullable restore
#line 19 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_ProductComponent\Default.cshtml"
                                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <div class=\"d-flex justify-content-center\">\r\n                            <h6>");
#nullable restore
#line 21 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_ProductComponent\Default.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</h6><h6 class=\"text-muted ml-2\"><del></del></h6>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card-footer d-flex justify-content-between bg-light border\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1241, "\"", 1248, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm text-dark p-0""><i class=""fas fa-eye text-primary mr-1""></i>View Detail</a>
                        <a href=""/Cart/AddCart"" class=""btn btn-sm text-dark p-0""><i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart</a>
                    </div>
                </div>

            </div>
");
#nullable restore
#line 31 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_ProductComponent\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("          \r\n        </div>\r\n</div>\r\n<!-- Products End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Concrete.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

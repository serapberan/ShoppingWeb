#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4969e90d9779068f00ed8eef87fd4e70619d1483"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CQRSProduct_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CQRSProduct/Index.cshtml")]
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
#line 1 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\_ViewImports.cshtml"
using ETicaretShooping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\_ViewImports.cshtml"
using ETicaretShooping.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\_ViewImports.cshtml"
using DTO.DTOs.NotificationDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\_ViewImports.cshtml"
using ETicaretShooping.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\_ViewImports.cshtml"
using ETicaretShooping.CQRS.Results.ProductResult;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4969e90d9779068f00ed8eef87fd4e70619d1483", @"/Areas/Admin/Views/CQRSProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8146dabd5c8fe1c4d516a49306e0b4522b9567", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CQRSProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ETicaretShooping.CQRS.Results.ProductResult.GetAllProductQueryResult>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UIAdminPanelLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h3> Ürünler Bilgisi CQRS ile Kullanım</h3>
<hr style=""border-block-color:blue "" />
<br />
<table class=""table table-bordered"">
    <tr>
        <th>Sıra No</th>
        <th>Ürün Adı</th>
        <th>Resim</th>
        <th>Açıklaması</th>
        <th>Fiyat</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4969e90d9779068f00ed8eef87fd4e70619d14836097", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 667, "~/images/productimages/", 667, 23, true);
#nullable restore
#line 27 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml"
AddHtmlAttributeValue("", 690, item.ImageUrl, 690, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 868, "\"", 923, 2);
            WriteAttributeValue("", 875, "/Admin/CQRSProduct/DeleteProduct/", 875, 33, true);
#nullable restore
#line 32 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml"
WriteAttributeValue("", 908, item.ProductId, 908, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 988, "\"", 1044, 2);
            WriteAttributeValue("", 995, "/Admin/CQRSProduct/GetByIdProduct/", 995, 34, true);
#nullable restore
#line 33 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml"
WriteAttributeValue("", 1029, item.ProductId, 1029, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\CQRSProduct\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/CQRSProduct/AddProduct/\" class=\"btn btn-primary\">Yeni Ürün Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ETicaretShooping.CQRS.Results.ProductResult.GetAllProductQueryResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591

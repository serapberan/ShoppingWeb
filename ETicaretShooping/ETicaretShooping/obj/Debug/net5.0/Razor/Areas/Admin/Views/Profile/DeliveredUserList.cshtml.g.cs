#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\Profile\DeliveredUserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2854cfe5d3a0c91077888b3e4178153d4c8ec69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Profile_DeliveredUserList), @"mvc.1.0.view", @"/Areas/Admin/Views/Profile/DeliveredUserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2854cfe5d3a0c91077888b3e4178153d4c8ec69", @"/Areas/Admin/Views/Profile/DeliveredUserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8146dabd5c8fe1c4d516a49306e0b4522b9567", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Profile_DeliveredUserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Concrete.Order>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\Profile\DeliveredUserList.cshtml"
  
    ViewData["Title"] = "DeliveredUserList";
    Layout = "~/Views/Shared/_UIAdminPanelLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Kullan??c??n??n Ge??mi?? Al????veri?? Listesi</h3>
<hr />

<table class=""table table-bordered"">
    <tr>
        <th>S??ra No</th>
        <th>Sipari?? No</th>
        <th>??r??nler</th>
        <th>Fiyat??</th>
        <th>Tarih</th>
        <th>Detaylar</th>
    </tr>



");
#nullable restore
#line 24 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\Profile\DeliveredUserList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\Profile\DeliveredUserList.cshtml"
              count = count + 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 29 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\Profile\DeliveredUserList.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\Profile\DeliveredUserList.cshtml"
           Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f2854cfe5d3a0c91077888b3e4178153d4c8ec696636", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 638, "~/images/productimages/", 638, 23, true);
#nullable restore
#line 31 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\Profile\DeliveredUserList.cshtml"
AddHtmlAttributeValue("", 661, item.ProductImage, 661, 18, false);

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
#line 32 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\Profile\DeliveredUserList.cshtml"
           Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ???</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\Profile\DeliveredUserList.cshtml"
            Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\Profile\DeliveredUserList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Concrete.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591

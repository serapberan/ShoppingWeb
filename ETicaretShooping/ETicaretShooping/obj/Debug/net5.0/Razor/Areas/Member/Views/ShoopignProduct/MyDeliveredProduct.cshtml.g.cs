#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a466808612a0534c3439ab84bfb8b6ae1a016d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_ShoopignProduct_MyDeliveredProduct), @"mvc.1.0.view", @"/Areas/Member/Views/ShoopignProduct/MyDeliveredProduct.cshtml")]
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
#line 1 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\_ViewImports.cshtml"
using ETicaretShooping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\_ViewImports.cshtml"
using ETicaretShooping.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a466808612a0534c3439ab84bfb8b6ae1a016d2", @"/Areas/Member/Views/ShoopignProduct/MyDeliveredProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ce84a101de21b3e2304fcaba45e4fc00284ab2", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_ShoopignProduct_MyDeliveredProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml"
  
    ViewData["Title"] = "MyDeliveredProduct";
    Layout = "~/Views/Shared/_UIUserPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3 class=\"text-sm-center bg-success\"> Hoşgeldin  ");
#nullable restore
#line 9 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml"
                                             Write(ViewBag.v);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
<br />
<h5>Teslim Edilmiş Sipariş Listen</h5>
<hr />
<table class=""table table-bordered"">
    <tr>
        <th>Resmi</th>
        <th>Sipariş No</th>
        <th>Sipariş Tarihi</th>
        <th>Ürün Fiyatı</th>
        <th>Durum</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a466808612a0534c3439ab84bfb8b6ae1a016d24819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 565, "~/images/productimages/", 565, 23, true);
#nullable restore
#line 24 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml"
AddHtmlAttributeValue("", 588, item.ProductImage, 588, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml"
           Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml"
           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml"
           Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml"
           Write(item.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\ShoopignProduct\MyDeliveredProduct.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591

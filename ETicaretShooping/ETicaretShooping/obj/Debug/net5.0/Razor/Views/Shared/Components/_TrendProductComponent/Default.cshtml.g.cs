#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_TrendProductComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d451d8e9a96b2ef6b1e5e945a895e19d62818585"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TrendProductComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TrendProductComponent/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_TrendProductComponent\Default.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d451d8e9a96b2ef6b1e5e945a895e19d62818585", @"/Views/Shared/Components/_TrendProductComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ad6d06a4c71770f3cf2b670355c7b522b12ae9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__TrendProductComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- _TrendProductComponent Start -->
<!-- Products Start -->

<div class=""container-fluid pt-5"">
    <div class=""text-center mb-4"">
        <h2 class=""section-title px-5""><span class=""px-2"">Trend Ürünler</span></h2>
    </div>
   
    <div class=""row px-xl-5 pb-3"">
");
#nullable restore
#line 12 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_TrendProductComponent\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-3 col-md-6 col-sm-12 pb-1"">
                <div class=""card product-item border-0 mb-4"">
                    <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                        <img class=""img-fluid w-100""");
            BeginWriteAttribute("src", " src=\"", 667, "\"", 687, 1);
#nullable restore
#line 17 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_TrendProductComponent\Default.cshtml"
WriteAttributeValue("", 673, item.ImageUrl, 673, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 688, "\"", 694, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"card-body border-left border-right text-center p-0 pt-4 pb-3\">\r\n                        <h6 class=\"text-truncate mb-3\">");
#nullable restore
#line 20 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_TrendProductComponent\Default.cshtml"
                                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <div class=\"d-flex justify-content-center\">\r\n                            <h6>");
#nullable restore
#line 22 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_TrendProductComponent\Default.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</h6>");
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card-footer d-flex justify-content-between bg-light border\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1257, "\"", 1312, 2);
            WriteAttributeValue("", 1264, "/ProductDetail/ProductDetailPage/", 1264, 33, true);
#nullable restore
#line 26 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_TrendProductComponent\Default.cshtml"
WriteAttributeValue("", 1297, item.ProductId, 1297, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-eye text-primary mr-1\"></i>Ürün Detayı</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1434, "\"", 1467, 2);
            WriteAttributeValue("", 1441, "Cart/Index/", 1441, 11, true);
#nullable restore
#line 27 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_TrendProductComponent\Default.cshtml"
WriteAttributeValue("", 1452, item.ProductId, 1452, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-shopping-cart text-primary mr-1\"></i>Sepete Ekle</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 31 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Shared\Components\_TrendProductComponent\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<!-- Products End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
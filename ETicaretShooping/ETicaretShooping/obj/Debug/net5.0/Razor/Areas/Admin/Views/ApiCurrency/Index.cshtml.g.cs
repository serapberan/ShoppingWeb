#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\ApiCurrency\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bfb49d05d75b4e5672b6c0ee82cd8113988587a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ApiCurrency_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ApiCurrency/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfb49d05d75b4e5672b6c0ee82cd8113988587a", @"/Areas/Admin/Views/ApiCurrency/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8146dabd5c8fe1c4d516a49306e0b4522b9567", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ApiCurrency_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ETicaretShooping.Areas.Admin.Models.CurrencyApiViewModel.Exchange_Rates>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\ApiCurrency\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UIAdminPanelLayout.cshtml";
    int count = 0;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3> Günlük Döviz Kur Bilgisi</h3>\r\n<hr />\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Sıra No</th>\r\n        <th>Tarih</th>\r\n        <th>Döviz Kur Adı</th>\r\n        <th>Kur Bilgisi</th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\ApiCurrency\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 24 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\ApiCurrency\Index.cshtml"
              count = count + 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>");
#nullable restore
#line 25 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\ApiCurrency\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\ApiCurrency\Index.cshtml"
           Write(DateTime.Now.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <th>");
#nullable restore
#line 27 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\ApiCurrency\Index.cshtml"
           Write(item.currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\ApiCurrency\Index.cshtml"
           Write(item.exchange_rate_buy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td><a href=\"#\" class=\"btn btn-outline-info\">Kur Bilgisi</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\ApiCurrency\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ETicaretShooping.Areas.Admin.Models.CurrencyApiViewModel.Exchange_Rates>> Html { get; private set; }
    }
}
#pragma warning restore 1591

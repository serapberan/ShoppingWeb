#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0c638f6520e0add6b27a29fd347b6955353c0c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MediatRProduct_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/MediatRProduct/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c638f6520e0add6b27a29fd347b6955353c0c9", @"/Areas/Admin/Views/MediatRProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158e3fcc88f78467e0cf74afb61dfcfc5abb9ac8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_MediatRProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ETicaretShooping.CQRS.Results.OrderResult.GetAllOrderQueryResult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UIAdminPanelLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h4> MediatR ile Sipari?? Listesi</h4>
<hr />
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Sipari?? No</th>
        <th>Kullan??c?? Id</th>
        <th>??r??n Ad??</th>
        <th>Fiyat</th>
        <th>Adet</th>
        <th>Tarih</th>
        <th>Adres</th>
        <th>??ehir</th>
        <th>Sil</th>
        <th>G??ncelle</th>
    </tr>
");
#nullable restore
#line 25 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
           Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
           Write(item.AppUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
           Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
            Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1107, "\"", 1159, 2);
            WriteAttributeValue("", 1114, "/Admin/MediatRProduct/GetGuides/", 1114, 32, true);
#nullable restore
#line 39 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
WriteAttributeValue("", 1146, item.OrderId, 1146, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">G??ncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Admin\Views\MediatRProduct\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/MediatRProduct/AddGuide/\" class=\"btn btn-outline-primary\">Sipari?? Olu??tur</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ETicaretShooping.CQRS.Results.OrderResult.GetAllOrderQueryResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591

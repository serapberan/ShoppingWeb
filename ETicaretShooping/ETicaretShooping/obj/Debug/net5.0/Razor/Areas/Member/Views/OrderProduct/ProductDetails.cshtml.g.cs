#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a0b5ff01b6f6d69d839d183d9f7b24ad0e07eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_OrderProduct_ProductDetails), @"mvc.1.0.view", @"/Areas/Member/Views/OrderProduct/ProductDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a0b5ff01b6f6d69d839d183d9f7b24ad0e07eb", @"/Areas/Member/Views/OrderProduct/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ce84a101de21b3e2304fcaba45e4fc00284ab2", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_OrderProduct_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Concrete.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
  
    ViewData["Title"] = "ProductDetails";
    Layout = "~/Views/Shared/_UIDetailLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ProductDetails</h1>\r\n\r\n<div class=\"container\">\r\n    <br />\r\n    <div class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28a0b5ff01b6f6d69d839d183d9f7b24ad0e07eb5386", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28a0b5ff01b6f6d69d839d183d9f7b24ad0e07eb5656", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 13 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"card mb-12\">\r\n                <div class=\"row g-0\">\r\n                    <div class=\"col-md-4\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 454, "\"", 480, 1);
#nullable restore
#line 17 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
WriteAttributeValue("", 460, Model.Product.Image, 460, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid rounded-start"" alt=""..."" style=""height:300px"">
                    </div>
                    <div class=""col-md-8"">
                        <div class=""card-body"">
                            <dl class=""row"">
                                <dt class=""col-sm-3 text-primary"">
                                    Stok
                                </dt>
                                <dd class=""col-sm-9"">
");
#nullable restore
#line 26 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
                                     if (Model.Product.Stock >=100)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <label class=\"btn btn-success \"><i class=\"bi bi-check\"></i> Var</label>\r\n");
#nullable restore
#line 29 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <label class=\"btn btn-danger\"><i class=\"bi bi-x\"></i> Yok</label>\r\n");
#nullable restore
#line 33 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </dd>
                                <dt class=""col-sm-3"">
                                    Başlık
                                </dt>
                                <dd class=""col-sm-9"">
                                    ");
#nullable restore
#line 39 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
                               Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-3"">
                                    Açıklama
                                </dt>
                                <dd class=""col-sm-9"">
                                    ");
#nullable restore
#line 45 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
                               Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-3"">
                                    Fiyat
                                </dt>
                                <dd class=""col-sm-9"">
                                    ");
#nullable restore
#line 51 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
                               Write(Model.Product.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"₺
                                </dd>
                                <dt class=""col-sm-3"">
                                    Adet
                                </dt>
                                <dd class=""col-sm-9"">
                                    <input class=""form-control"" />
                                </dd>
                            </dl>

                        </div>
                    </div>

                    <br />
                    <div class=""col-md-1"">

                    </div>
                    <div class=""col-md-3"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28a0b5ff01b6f6d69d839d183d9f7b24ad0e07eb12066", async() => {
                    WriteLiteral("<i class=\"bi bi-house-fill\"></i> Anasayfa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 72 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
                         if (Model.Product.Stock >= 100)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button type=\"submit\" class=\"btn btn-success form-control \"><i class=\"bi bi-cart-check-fill\"></i> Sepete Ekle</button>\r\n");
#nullable restore
#line 75 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <label class=\"btn btn-danger form-control\"><i class=\"bi bi-cart-x-fill\"></i> Ürün Tükenmiştir</label>\r\n");
#nullable restore
#line 79 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Areas\Member\Views\OrderProduct\ProductDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <div class=\"col-md-3\">\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Concrete.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
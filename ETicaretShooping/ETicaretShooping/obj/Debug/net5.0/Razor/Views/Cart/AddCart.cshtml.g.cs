#pragma checksum "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Cart\AddCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411902840d90fcfdab3ef667507fd399d2103c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_AddCart), @"mvc.1.0.view", @"/Views/Cart/AddCart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"411902840d90fcfdab3ef667507fd399d2103c3f", @"/Views/Cart/AddCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ce84a101de21b3e2304fcaba45e4fc00284ab2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_AddCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Concrete.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Cart\AddCart.cshtml"
  
    ViewData["Title"] = "AddCart";
    Layout = "~/Views/Shared/_UIDetailLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AddCart</h1>\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411902840d90fcfdab3ef667507fd399d2103c3f5283", async() => {
                WriteLiteral(@"
    <!-- Topbar Start -->

    <!-- Topbar End -->
    <!-- Navbar Start -->

    <!-- Navbar End -->
    <!-- Page Header Start -->
    
    <!-- Page Header End -->
    <!-- Cart Start -->
    <div class=""container-fluid pt-5"">
        <div class=""row px-xl-5"">
            <div class=""col-lg-8 table-responsive mb-5"">
                <table class=""table table-bordered text-center mb-0"">
                    <thead class=""bg-secondary text-dark"">
                        <tr>
                            <th>Products</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Total</th>
                            <th>Remove</th>
                        </tr>
                    </thead>
                    <tbody class=""align-middle"">
");
#nullable restore
#line 37 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Cart\AddCart.cshtml"
                         foreach (var item in Model)
                        {



#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td class=\"align-middle\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "411902840d90fcfdab3ef667507fd399d2103c3f6761", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1213, "~/", 1213, 2, true);
#nullable restore
#line 42 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Cart\AddCart.cshtml"
AddHtmlAttributeValue("", 1215, item.ProductImage, 1215, 18, false);

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
                WriteLiteral(" Colorful Stylish Shirt</td>\r\n                            <td class=\"align-middle\">");
#nullable restore
#line 43 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Cart\AddCart.cshtml"
                                                Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                            <td class=""align-middle"">
                                <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                    <div class=""input-group-btn"">
                                        <button class=""btn btn-sm btn-primary btn-minus"">
                                            <i class=""fa fa-minus""></i>
                                        </button>
                                    </div>
                                    <input type=""text"" class=""form-control form-control-sm bg-secondary text-center""");
                BeginWriteAttribute("value", " value=\"", 1959, "\"", 1981, 1);
#nullable restore
#line 51 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Cart\AddCart.cshtml"
WriteAttributeValue("", 1967, item.Quantity, 1967, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    <div class=""input-group-btn"">
                                        <button class=""btn btn-sm btn-primary btn-plus"">
                                            <i class=""fa fa-plus""></i>
                                        </button>
                                    </div>
                                </div>
                            </td>
                            <td class=""align-middle"">");
#nullable restore
#line 59 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Cart\AddCart.cshtml"
                                                Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" * ");
#nullable restore
#line 59 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Cart\AddCart.cshtml"
                                                              Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td class=\"align-middle\"><button class=\"btn btn-sm btn-primary\"><i class=\"fa fa-times\"></i></button></td>\r\n                        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\serap\source\repos\ETicaretShooping\ETicaretShooping\Views\Cart\AddCart.cshtml"

                    
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <div class=\"col-lg-4\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411902840d90fcfdab3ef667507fd399d2103c3f11458", async() => {
                    WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control p-4"" placeholder=""Coupon Code"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"">Apply Coupon</button>
                        </div>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""card border-secondary mb-5"">
                    <div class=""card-header bg-secondary border-0"">
                        <h4 class=""font-weight-semi-bold m-0"">Cart Summary</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between mb-3 pt-1"">
                            <h6 class=""font-weight-medium"">Subtotal</h6>
                            <h6 class=""font-weight-medium""></h6>
                        </div>
                        <div class=""d-flex justify-content-between"">
                            <h6 class=""font-weight-medium"">Shipping</h6>
                            <h6 class=""font-weight-medium"">$10</h6>
                        </div>
                    </div>
                    <div class=""card-footer border-secondary bg-transparent"">
                        <div class=""d-flex justify-content-between mt-2"">
                            <h5 class=""font-weight-bold"">Total");
                WriteLiteral(@"</h5>
                            <h5 class=""font-weight-bold"">$160</h5>
                        </div>
                        <button class=""btn btn-block btn-primary my-3 py-3"">Proceed To Checkout</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Cart End -->
    <!-- Footer Start -->
    <div class=""container-fluid bg-secondary text-dark mt-5 pt-5"">
        <div class=""row px-xl-5 pt-5"">
            <div class=""col-lg-4 col-md-12 mb-5 pr-3 pr-xl-5"">
                <a");
                BeginWriteAttribute("href", " href=\"", 4794, "\"", 4801, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none"">
                    <h1 class=""mb-4 display-5 font-weight-semi-bold""><span class=""text-primary font-weight-bold border border-white px-3 mr-1"">E</span>Shopper</h1>
                </a>
                <p>Dolore erat dolor sit lorem vero amet. Sed sit lorem magna, ipsum no sit erat lorem et magna ipsum dolore amet erat.</p>
                <p class=""mb-2""><i class=""fa fa-map-marker-alt text-primary mr-3""></i>123 Street, New York, USA</p>
                <p class=""mb-2""><i class=""fa fa-envelope text-primary mr-3""></i>info@example.com</p>
                <p class=""mb-0""><i class=""fa fa-phone-alt text-primary mr-3""></i>+012 345 67890</p>
            </div>
            <div class=""col-lg-8 col-md-12"">
                <div class=""row"">
                    <div class=""col-md-4 mb-5"">
                        <h5 class=""font-weight-bold text-dark mb-4"">Quick Links</h5>
                        <div class=""d-flex flex-column justify-content-start"">
                            ");
                WriteLiteral(@"<a class=""text-dark mb-2"" href=""index.html""><i class=""fa fa-angle-right mr-2""></i>Home</a>
                            <a class=""text-dark mb-2"" href=""shop.html""><i class=""fa fa-angle-right mr-2""></i>Our Shop</a>
                            <a class=""text-dark mb-2"" href=""detail.html""><i class=""fa fa-angle-right mr-2""></i>Shop Detail</a>
                            <a class=""text-dark mb-2"" href=""cart.html""><i class=""fa fa-angle-right mr-2""></i>Shopping Cart</a>
                            <a class=""text-dark mb-2"" href=""checkout.html""><i class=""fa fa-angle-right mr-2""></i>Checkout</a>
                            <a class=""text-dark"" href=""contact.html""><i class=""fa fa-angle-right mr-2""></i>Contact Us</a>
                        </div>
                    </div>
                    <div class=""col-md-4 mb-5"">
                        <h5 class=""font-weight-bold text-dark mb-4"">Quick Links</h5>
                        <div class=""d-flex flex-column justify-content-start"">
                            ");
                WriteLiteral(@"<a class=""text-dark mb-2"" href=""index.html""><i class=""fa fa-angle-right mr-2""></i>Home</a>
                            <a class=""text-dark mb-2"" href=""shop.html""><i class=""fa fa-angle-right mr-2""></i>Our Shop</a>
                            <a class=""text-dark mb-2"" href=""detail.html""><i class=""fa fa-angle-right mr-2""></i>Shop Detail</a>
                            <a class=""text-dark mb-2"" href=""cart.html""><i class=""fa fa-angle-right mr-2""></i>Shopping Cart</a>
                            <a class=""text-dark mb-2"" href=""checkout.html""><i class=""fa fa-angle-right mr-2""></i>Checkout</a>
                            <a class=""text-dark"" href=""contact.html""><i class=""fa fa-angle-right mr-2""></i>Contact Us</a>
                        </div>
                    </div>
                    <div class=""col-md-4 mb-5"">
                        <h5 class=""font-weight-bold text-dark mb-4"">Newsletter</h5>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411902840d90fcfdab3ef667507fd399d2103c3f18267", async() => {
                    WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control border-0 py-4"" placeholder=""Your Name"" required=""required"" />
                            </div>
                            <div class=""form-group"">
                                <input type=""email"" class=""form-control border-0 py-4"" placeholder=""Your Email""
                                       required=""required"" />
                            </div>
                            <div>
                                <button class=""btn btn-primary btn-block border-0 py-3"" type=""submit"">Subscribe Now</button>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""row border-top border-light mx-xl-5 py-4"">
            <div class=""col-md-6 px-xl-0"">
                <p class=""mb-md-0 text-center text-md-left text-dark"">
                    &copy; <a class=""text-dark font-weight-semi-bold"" href=""#"">Your Site Name</a>. All Rights Reserved. Designed
                    by
                    <a class=""text-dark font-weight-semi-bold"" href=""https://htmlcodex.com"">HTML Codex</a><br>
                    Distributed By <a href=""https://themewagon.com"" target=""_blank"">ThemeWagon</a>
                </p>
            </div>
            <div class=""col-md-6 px-xl-0 text-center text-md-right"">
                <img class=""img-fluid"" src=""img/payments.png""");
                BeginWriteAttribute("alt", " alt=\"", 9334, "\"", 9340, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </div>
        </div>
    </div>
    <!-- Footer End -->
    <!-- Back to Top -->
    <a href=""#"" class=""btn btn-primary back-to-top""><i class=""fa fa-angle-double-up""></i></a>


    <!-- JavaScript Libraries -->
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js""></script>
    <script src=""lib/easing/easing.min.js""></script>
    <script src=""lib/owlcarousel/owl.carousel.min.js""></script>

    <!-- Contact Javascript File -->
    <script src=""mail/jqBootstrapValidation.min.js""></script>
    <script src=""mail/contact.js""></script>

    <!-- Template Javascript -->
    <script src=""js/main.js""></script>
");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Concrete.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b39ea2205ac5d089b0f522b71a5bb9945712843f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_Index), @"mvc.1.0.view", @"/Views/Card/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Card/Index.cshtml", typeof(AspNetCore.Views_Card_Index))]
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
#line 1 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Entity;

#line default
#line hidden
#line 2 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39ea2205ac5d089b0f522b71a5bb9945712843f", @"/Views/Card/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fba35f382838d6766da855ace12e9c7a7ad9c0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Card>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive product-thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Card", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(54, 816, true);
            WriteLiteral(@"
<section id=""content"">

    <!-- shop section start -->
    <section id=""cart"" class=""container"">

        <!-- row start -->
        <div class=""row"">

            <!-- cart contents start -->
            <div class=""col-md-8"">
                <div class=""table-responsive"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th></th>
                                <th>Product</th>
                                <th>Price</th>
                                <th class=""qtycolumn"">Quantity</th>
                                <th>Total</th>
                                <th></th>
                            </tr>
                        </thead>

                        <tbody>
");
            EndContext();
#line 30 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
                             foreach (var item in Model.Products)
                            {

#line default
#line hidden
            BeginContext(968, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1046, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b39ea2205ac5d089b0f522b71a5bb9945712843f7833", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1100, "~/images/products/small/", 1100, 24, true);
#line 33 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
AddHtmlAttributeValue("", 1124, item.Product.Image, 1124, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1145, 59, true);
            WriteLiteral("</td>\r\n                                    <td><a href=\"#\">");
            EndContext();
            BeginContext(1205, 24, false);
#line 34 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
                                               Write(item.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1229, 51, true);
            WriteLiteral("</a></td>\r\n                                    <td>");
            EndContext();
            BeginContext(1281, 32, false);
#line 35 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
                                   Write(item.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 200, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <div class=\"form-group\">\r\n                                            <input type=\"number\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1513, "\"", 1535, 1);
#line 38 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
WriteAttributeValue("", 1521, item.Quantity, 1521, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1536, 151, true);
            WriteLiteral(" min=\"1\" step=\"1\">\r\n                                        </div>\r\n                                    </td>\r\n                                    <td>");
            EndContext();
            BeginContext(1689, 50, false);
#line 41 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
                                    Write((item.Quantity * item.Product.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 89, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1829, 526, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39ea2205ac5d089b0f522b71a5bb9945712843f11665", async() => {
                BeginContext(1899, 83, true);
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"ProductId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1982, "\"", 2013, 1);
#line 44 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
WriteAttributeValue("", 1990, item.Product.ProductId, 1990, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2014, 334, true);
                WriteLiteral(@" />
                                            <button type=""submit"" class=""btn btn-danger btn-sm"">
                                                Sil
                                                <i class=""fa fa-times fa-fw""></i>
                                            </button>
                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2355, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2470, 706, true);
            WriteLiteral(@"
                        </tbody>

                    </table>

                </div>

                <div class=""text-right"">
                    <a href=""#"" class=""btn btn-default""><i class=""fa fa-refresh fa-fw""></i> Update Cart</a>
                </div>

            </div>
            <!-- cart contents end -->
            <!-- cart total start -->
            <div class=""col-md-4"">
                <div class=""text-left"">
                    <h4>CART <b>TOTALS</b></h4>
                </div>

                <table class=""table"">
                    <tbody>
                        <tr>
                            <th>Cart Subtotal</th>
                            <td>");
            EndContext();
            BeginContext(3177, 31, false);
#line 76 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
                           Write(Model.TotalPrce().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(3208, 321, true);
            WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <th>Shipping</th>
                            <td>Free</td>
                        </tr>
                        <tr>
                            <th>Order Total</th> 
                            <td class=""ordertotal"">");
            EndContext();
            BeginContext(3530, 31, false);
#line 84 "C:\Users\Alizamin\Desktop\Edura\Edura.WebUI\Views\Card\Index.cshtml"
                                              Write(Model.TotalPrce().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(3561, 159, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n\r\n                <div class=\"text-center\">\r\n                    ");
            EndContext();
            BeginContext(3720, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39ea2205ac5d089b0f522b71a5bb9945712843f16835", async() => {
                BeginContext(3795, 63, true);
                WriteLiteral("<i class=\"fa fa-arrow-circle-left fa-fw\"></i> Yeni Mehsullar Al");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3862, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3884, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39ea2205ac5d089b0f522b71a5bb9945712843f18579", async() => {
                BeginContext(3962, 55, true);
                WriteLiteral("Checkout <i class=\"fa fa-arrow-circle-right fa-fw\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4021, 194, true);
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n            <!-- cart total end -->\r\n\r\n\r\n        </div>\r\n        <!-- row end -->\r\n\r\n    </section>\r\n    <!-- shop section end -->\r\n\r\n</section>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Card> Html { get; private set; }
    }
}
#pragma warning restore 1591

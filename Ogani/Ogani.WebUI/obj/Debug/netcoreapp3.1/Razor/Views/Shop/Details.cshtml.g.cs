#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76368561ad615d02dd7545876bcb349d5f8f1f14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.Shop.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
namespace Ogani.WebUI.Views.Shop
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
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Ogani.WebUI.AppCode.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/_ViewImports.cshtml"
using Ogani.WebUI.AppCode.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76368561ad615d02dd7545876bcb349d5f8f1f14", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b731d2a1c19d2c61f2c786dd2cef5d63154b374", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-details-pic-item--large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
  
    ViewBag.Title = "Shop Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""breadcrumb-section set-bg"" data-setbg=""assets/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb-text"">
                    <h2>");
#nullable restore
#line 12 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <div class=\"breadcrumb-option\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76368561ad615d02dd7545876bcb349d5f8f1f145783", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76368561ad615d02dd7545876bcb349d5f8f1f147146", async() => {
                WriteLiteral("Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <span>");
#nullable restore
#line 16 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""product-details spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6"">
                <div class=""product-details-pic"">
                    <div class=""product-details-pic-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "76368561ad615d02dd7545876bcb349d5f8f1f148965", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 991, "~/uploads/images/products/", 991, 26, true);
#nullable restore
#line 31 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
AddHtmlAttributeValue("", 1017, Model.Images?.FirstOrDefault(i => i.IsMain)?.ImagePath, 1017, 55, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
AddHtmlAttributeValue("", 1079, Model.Name, 1079, 11, false);

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
            WriteLiteral("\n                    </div>\n                    <div class=\"product-details-pic-slider owl-carousel\">\n");
#nullable restore
#line 34 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                         foreach (var img in Model.Images?.Where(i => !i.IsMain))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "76368561ad615d02dd7545876bcb349d5f8f1f1411515", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1340, "~/uploads/images/products/", 1340, 26, true);
#nullable restore
#line 36 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
AddHtmlAttributeValue("", 1366, img.ImagePath, 1366, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
AddHtmlAttributeValue("", 1387, Model.Name, 1387, 11, false);

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
            WriteLiteral("\n");
#nullable restore
#line 37 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n            <div class=\"col-lg-6 col-md-6\">\n                <div class=\"product-details-text\">\n                    <h3>");
#nullable restore
#line 43 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <div class=""product-details-rating"">
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star-half-o""></i>
                        <span>(18 reviews)</span>
                    </div>
                    <div class=""product-details-price"">$");
#nullable restore
#line 52 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                                                   Write(Model.Price.ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <p>\n                        ");
#nullable restore
#line 54 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                   Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <div class=""product-details-quantity"">
                        <div class=""quantity"">
                            <div class=""pro-qty"">
                                <input type=""text"" value=""1"">
                            </div>
                        </div>
                    </div>
                    <a href=""#"" class=""primary-btn"">ADD TO CARD</a>
                    <a href=""#"" class=""heart-icon""><span class=""icon_heart_alt""></span></a>
                    <ul>
                        <li><b>Availability</b> <span>In Stock</span></li>
                        <li><b>Shipping</b> <span>01 day shipping. <samp>Free pickup today</samp></span></li>
                        <li><b>Weight</b> <span>");
#nullable restore
#line 68 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                                           Write(Model.Weight.ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 68 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                                                                          Write(Model.Unit.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                        <li>
                            <b>Share on</b>
                            <div class=""share"">
                                <a href=""#""><i class=""fa fa-facebook""></i></a>
                                <a href=""#""><i class=""fa fa-twitter""></i></a>
                                <a href=""#""><i class=""fa fa-instagram""></i></a>
                                <a href=""#""><i class=""fa fa-pinterest""></i></a>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-12"">
                <div class=""product-details-tab"">
                    <ul class=""nav nav-tabs"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" data-toggle=""tab"" href=""#tabs-1"" role=""tab"" aria-selected=""true"">Description</a>
                        </li>
                        <li class=""nav-item"">
                            <a clas");
            WriteLiteral(@"s=""nav-link"" data-toggle=""tab"" href=""#tabs-2"" role=""tab"" aria-selected=""false"">Information</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-3"" role=""tab"" aria-selected=""false"">Reviews <span>(1)</span></a>
                        </li>
                    </ul>
                    <div class=""tab-content"">
                        <div class=""tab-pane active"" id=""tabs-1"" role=""tabpanel"">
                            <div class=""product-details-tab-desc"">
                                ");
#nullable restore
#line 97 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                           Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"tab-pane\" id=\"tabs-2\" role=\"tabpanel\">\n                            <div class=\"product-details-tab-desc\">\n                                ");
#nullable restore
#line 102 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                           Write(Html.Raw(Model.Information));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"tab-pane\" id=\"tabs-3\" role=\"tabpanel\">\n                            <div class=\"product-details-tab-desc\">\n                                ");
#nullable restore
#line 107 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                           Write(Html.Raw(Model.Reviews));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""related-product"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title related-product-title"">
                    <h2>Related Product</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 col-md-4 col-sm-6"">
                <div class=""product-item"">
                    <div class=""product-item-pic set-bg"" data-setbg=""assets/img/product/product-1.jpg"">
                        <ul class=""product-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                  ");
            WriteLiteral(@"      </ul>
                    </div>
                    <div class=""product-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6"">
                <div class=""product-item"">
                    <div class=""product-item-pic set-bg"" data-setbg=""assets/img/product/product-2.jpg"">
                        <ul class=""product-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""product-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>");
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6"">
                <div class=""product-item"">
                    <div class=""product-item-pic set-bg"" data-setbg=""assets/img/product/product-3.jpg"">
                        <ul class=""product-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""product-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6"">
                <div class=""product-item"">
                    <div class=""product-item-pic set-bg"" data-setbg=""assets/img/produc");
            WriteLiteral(@"t/product-7.jpg"">
                        <ul class=""product-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""product-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a624dd21c3e683184db884f00f5f358a33325b98"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a624dd21c3e683184db884f00f5f358a33325b98", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89a98e261c88b19f8eb839873589ad3c1edf0d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section class=""hero hero-normal"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""hero-categories"">
                    <div class=""hero-categories-all"">
                        <i class=""fa fa-bars""></i>
                        <span>All departments</span>
                    </div>
                    <ul>
                        <li><a href=""#"">Fresh Meat</a></li>
                        <li><a href=""#"">Vegetables</a></li>
                        <li><a href=""#"">Fruit & Nut Gifts</a></li>
                        <li><a href=""#"">Fresh Berries</a></li>
                        <li><a href=""#"">Ocean Foods</a></li>
                        <li><a href=""#"">Butter & Eggs</a></li>
                        <li><a href=""#"">Fastfood</a></li>
                        <li><a href=""#"">Fresh Onion</a></li>
                        <li><a href=""#"">Papayaya & Crisps</a></li>
                        <li><a href=""#"">Oatmeal</a></li>
                        ");
            WriteLiteral(@"<li><a href=""#"">Fresh Bananas</a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-9"">
                <div class=""hero-search"">
                    <div class=""hero-search-form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a624dd21c3e683184db884f00f5f358a33325b985027", async() => {
                WriteLiteral(@"
                            <div class=""hero-search-categories"">
                                All Categories
                                <span class=""arrow_carrot-down""></span>
                            </div>
                            <input type=""text"" placeholder=""What do yo u need?"">
                            <button type=""submit"" class=""site-btn"">SEARCH</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""hero-search-phone"">
                        <div class=""hero-search-phone-icon"">
                            <i class=""fa fa-phone""></i>
                        </div>
                        <div class=""hero-search-phone-text"">
                            <h5>+65 11.188.888</h5>
                            <span>support 24/7 time</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""breadcrumb-section set-bg"" data-setbg=""assets/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb-text"">
                    <h2>Vegetable’s Package</h2>
                    <div class=""breadcrumb-option"">
                        <a href=""index-2.html"">Home</a>
                        <a href=""index-2.html"">Vegetables</a>
                        <span>Veget");
            WriteLiteral(@"able’s Package</span>
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
                        <img class=""product-details-pic-item--large""");
            BeginWriteAttribute("src", " src=\"", 3234, "\"", 3321, 2);
            WriteAttributeValue("", 3240, "assets/img/product/details/", 3240, 27, true);
#nullable restore
#line 84 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
WriteAttributeValue("", 3267, Model.Images.FirstOrDefault(i => i.IsMain)?.ImagePath, 3267, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3322, "\"", 3328, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n                    <div class=\"product-details-pic-slider owl-carousel\">\n");
#nullable restore
#line 87 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                         foreach (var img in Model.Images.Where(i => !i.IsMain))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 3571, "\"", 3618, 2);
            WriteAttributeValue("", 3577, "assets/img/product/details/", 3577, 27, true);
#nullable restore
#line 89 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
WriteAttributeValue("", 3604, img.ImagePath, 3604, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3619, "\"", 3625, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 90 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n            <div class=\"col-lg-6 col-md-6\">\n                <div class=\"product-details-text\">\n                    <h3>");
#nullable restore
#line 96 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
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
#line 105 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <p>\n                        ");
#nullable restore
#line 107 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
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
#line 121 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                                           Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 121 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
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
#line 150 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                           Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"tab-pane\" id=\"tabs-2\" role=\"tabpanel\">\n                            <div class=\"product-details-tab-desc\">\n                                ");
#nullable restore
#line 155 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
                           Write(Html.Raw(Model.Information));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"tab-pane\" id=\"tabs-3\" role=\"tabpanel\">\n                            <div class=\"product-details-tab-desc\">\n                                ");
#nullable restore
#line 160 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Details.cshtml"
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

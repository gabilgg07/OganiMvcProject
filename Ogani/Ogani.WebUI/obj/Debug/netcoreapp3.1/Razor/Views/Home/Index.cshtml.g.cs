#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1884de25d0397091d42bc7f9c47d7db38781d19d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace Ogani.WebUI.Views.Home
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1884de25d0397091d42bc7f9c47d7db38781d19d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"397dd3552672b938e82e1d2b5bc222493ece87a9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\n");
#nullable restore
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Home/Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""hero"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""hero-categories"">
                    <div class=""hero-categories-all"">
                        <i class=""fa fa-bars""></i>
                        <span>All departments</span>
                    </div>
                    ");
#nullable restore
#line 16 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Home/Index.cshtml"
               Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-lg-9\">\n                <div class=\"hero-search\">\n                    <div class=\"hero-search-form\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1884de25d0397091d42bc7f9c47d7db38781d19d4763", async() => {
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
                <div class=""hero-item set-bg"" data-setbg=""assets/img/hero/banner.jpg"">
                    <div class=""hero-text"">
                        <span>FRUIT FRESH</span>
                        <h2>Vegetable <br />100% Organic</h2>
                        <p>Free Pickup and Delivery Available</p>
                        <a href=""#"" class=""primary-btn"">SHOP NOW</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""categories"">
    <div class=""container"">
 ");
            WriteLiteral(@"       <div class=""row"">
            <div class=""categories-slider owl-carousel"">
                <div class=""col-lg-3"">
                    <div class=""categories-item set-bg"" data-setbg=""assets/img/categories/cat-1.jpg"">
                        <h5><a href=""#"">Fresh Fruit</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories-item set-bg"" data-setbg=""assets/img/categories/cat-2.jpg"">
                        <h5><a href=""#"">Dried Fruit</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories-item set-bg"" data-setbg=""assets/img/categories/cat-3.jpg"">
                        <h5><a href=""#"">Vegetables</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories-item set-bg"" data-setbg=""assets/img/categories/cat-4.jpg"">
                        <h5><a href=""#"">drink ");
            WriteLiteral(@"fruits</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories-item set-bg"" data-setbg=""assets/img/categories/cat-5.jpg"">
                        <h5><a href=""#"">drink fruits</a></h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""featured spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title"">
                    <h2>Featured Product</h2>
                </div>
                <div class=""featured-controls"">
                    <ul>
                        <li class=""active"" data-filter=""*"">All</li>
                        <li data-filter="".oranges"">Oranges</li>
                        <li data-filter="".fresh-meat"">Fresh Meat</li>
                        <li data-filter="".vegetables"">Vegetables</li>
                        <li data-filter="".fastfood"">Fastfood</li>
 ");
            WriteLiteral(@"                   </ul>
                </div>
            </div>
        </div>
        <div class=""row featured-filter"">
            <div class=""col-lg-3 col-md-4 col-sm-6 mix oranges fresh-meat"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-1.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix vegetables fastfoo");
            WriteLiteral(@"d"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-2.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix vegetables fresh-meat"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-3.jpg"">
                        <ul class=""featu");
            WriteLiteral(@"red-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix fastfood oranges"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-4.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
              ");
            WriteLiteral(@"              <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix fresh-meat vegetables"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-5.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
         ");
            WriteLiteral(@"               <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix oranges fastfood"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-6.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-");
            WriteLiteral(@"3 col-md-4 col-sm-6 mix fresh-meat vegetables"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-7.jpg"">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 mix fastfood vegetables"">
                <div class=""featured-item"">
                    <div class=""featured-item-pic set-bg"" data-setbg=""assets/img/featured/feature-8.jpg""");
            WriteLiteral(@">
                        <ul class=""featured-item-pic-hover"">
                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                        </ul>
                    </div>
                    <div class=""featured-item-text"">
                        <h6><a href=""#"">Crab Pool Security</a></h6>
                        <h5>$30.00</h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<div class=""banner"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""banner-pic"">
                    <img src=""assets/img/banner/banner-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11155, "\"", 11161, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                </div>\n            </div>\n            <div class=\"col-lg-6 col-md-6 col-sm-6\">\n                <div class=\"banner-pic\">\n                    <img src=\"assets/img/banner/banner-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 11361, "\"", 11367, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
        </div>
    </div>
</div>


<section class=""latest-product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""latest-product-text"">
                    <h4>Latest Products</h4>
                    <div class=""latest-product-slider owl-carousel"">
                        <div class=""latest-prdouct-slider-item"">
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12032, "\"", 12038, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12563, "\"", 12569, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13094, "\"", 13100, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                        <div class=""latest-prdouct-slider-item"">
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13721, "\"", 13727, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14252, "\"", 14258, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14783, "\"", 14789, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6"">
                <div class=""latest-product-text"">
                    <h4>Top Rated Products</h4>
                    <div class=""latest-product-slider owl-carousel"">
                        <div class=""latest-prdouct-slider-item"">
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15690, "\"", 15696, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 16221, "\"", 16227, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 16752, "\"", 16758, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                        <div class=""latest-prdouct-slider-item"">
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17379, "\"", 17385, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17910, "\"", 17916, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 18441, "\"", 18447, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6"">
                <div class=""latest-product-text"">
                    <h4>Review Products</h4>
                    <div class=""latest-product-slider owl-carousel"">
                        <div class=""latest-prdouct-slider-item"">
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 19345, "\"", 19351, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 19876, "\"", 19882, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 20407, "\"", 20413, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                        <div class=""latest-prdouct-slider-item"">
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 21034, "\"", 21040, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 21565, "\"", 21571, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                            <a href=""#"" class=""latest-product-item"">
                                <div class=""latest-product-item-pic"">
                                    <img src=""assets/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 22096, "\"", 22102, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""latest-product-item-text"">
                                    <h6>Crab Pool Security</h6>
                                    <span>$30.00</span>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""from-blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title from-blog-title"">
                    <h2>From The Blog</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog-item"">
                    <div class=""blog-item-pic"">
                        <img src=""assets/img/blog/blog-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 23057, "\"", 23063, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog-item-text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">Cooking tips make cooking simple</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog-item"">
                    <div class=""blog-item-pic"">
                        <img src=""assets/img/blog/blog-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 23822, "\"", 23828, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog-item-text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">6 ways to prepare breakfast for 30</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog-item"">
                    <div class=""blog-item-pic"">
                        <img src=""assets/img/blog/blog-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 24589, "\"", 24595, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog-item-text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">Visit the clean farm in the US</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Blog/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31423616197e1c210c78a7ea141fa8805a926da4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.Blog.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
namespace Ogani.WebUI.Views.Blog
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31423616197e1c210c78a7ea141fa8805a926da4", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8f8ca7cd44221e8ce904bda6799cf20b7028f2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Blog/Details.cshtml"
  
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
                    ");
#nullable restore
#line 15 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Blog/Details.cshtml"
               Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-lg-9\">\n                <div class=\"hero-search\">\n                    <div class=\"hero-search-form\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31423616197e1c210c78a7ea141fa8805a926da45190", async() => {
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


<section class=""blog-details-hero set-bg"" data-setbg=""assets/img/blog/details/details-hero.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""blog-details-hero-text"">
                    <h2>The Moment You Need To Remove Garlic From The Menu</h2>
                    <ul>
                        <li>By Michael Scofield</li>
                        <li>January 14, 2019</li>
                        <li>8 Comment");
            WriteLiteral(@"s</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""blog-details spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-5 order-md-1 order-2"">
                <div class=""blog-sidebar"">
                    <div class=""blog-sidebar-search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31423616197e1c210c78a7ea141fa8805a926da48376", async() => {
                WriteLiteral("\n                            <input type=\"text\" placeholder=\"Search...\">\n                            <button type=\"submit\"><span class=\"icon_search\"></span></button>\n                        ");
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
                    <div class=""blog-sidebar-item"">
                        <h4>Categories</h4>
                        <ul>
                            <li><a href=""#"">All</a></li>
                            <li><a href=""#"">Beauty (20)</a></li>
                            <li><a href=""#"">Food (5)</a></li>
                            <li><a href=""#"">Life Style (9)</a></li>
                            <li><a href=""#"">Travel (10)</a></li>
                        </ul>
                    </div>
                    <div class=""blog-sidebar-item"">
                        <h4>Recent News</h4>
                        <div class=""blog-sidebar-recent"">
                            <a href=""#"" class=""blog-sidebar-recent-item"">
                                <div class=""blog-sidebar-recent-item-pic"">
                                    <img src=""assets/img/blog/sidebar/sr-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3616, "\"", 3622, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog-sidebar-recent-item-text"">
                                    <h6>09 Kinds Of Vegetables<br /> Protect The Liver</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                            <a href=""#"" class=""blog-sidebar-recent-item"">
                                <div class=""blog-sidebar-recent-item-pic"">
                                    <img src=""assets/img/blog/sidebar/sr-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4194, "\"", 4200, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog-sidebar-recent-item-text"">
                                    <h6>Tips You To Balance<br /> Nutrition Meal Day</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                            <a href=""#"" class=""blog-sidebar-recent-item"">
                                <div class=""blog-sidebar-recent-item-pic"">
                                    <img src=""assets/img/blog/sidebar/sr-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4770, "\"", 4776, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog-sidebar-recent-item-text"">
                                    <h6>4 Principles Help You Lose <br />Weight With Vegetables</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""blog-sidebar-item"">
                        <h4>Search By</h4>
                        <div class=""blog-sidebar-item-tags"">
                            <a href=""#"">Apple</a>
                            <a href=""#"">Beauty</a>
                            <a href=""#"">Vegetables</a>
                            <a href=""#"">Fruit</a>
                            <a href=""#"">Healthy Food</a>
                            <a href=""#"">Lifestyle</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8 col-md-7");
            WriteLiteral(" order-md-1 order-1\">\n                <div class=\"blog-details-text\">\n                    <img src=\"assets/img/blog/details/details-pic.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5941, "\"", 5947, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <p>
                        Sed porttitor lectus nibh. Vestibulum ac diam sit amet quam vehicula elementum sed sit amet
                        dui. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Mauris blandit
                        aliquet elit, eget tincidunt nibh pulvinar a. Vivamus magna justo, lacinia eget consectetur
                        sed, convallis at tellus. Sed porttitor lectus nibh. Donec sollicitudin molestie malesuada.
                        Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Proin eget tortor risus.
                        Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis
                        quis ac lectus. Donec sollicitudin molestie malesuada. Nulla quis lorem ut libero malesuada
                        feugiat. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem.
                    </p>
                    <h3>
                        The corner window fo");
            WriteLiteral(@"rms a place within a place that is a resting point within the large
                        space.
                    </h3>
                    <p>
                        The study area is located at the back with a view of the vast nature. Together with the other
                        buildings, a congruent story has been managed in which the whole has a reinforcing effect on
                        the components. The use of materials seeks connection to the main house, the adjacent
                        stables
                    </p>
                </div>
                <div class=""blog-details-content"">
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <div class=""blog-details-author"">
                                <div class=""blog-details-author-pic"">
                                    <img src=""assets/img/blog/details/details-author.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7903, "\"", 7909, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog-details-author-text"">
                                    <h6>Michael Scofield</h6>
                                    <span>Admin</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""blog-details-widget"">
                                <ul>
                                    <li><span>Categories:</span> Food</li>
                                    <li><span>Tags:</span> All, Trending, Cooking, Healthy Food, Life Style</li>
                                </ul>
                                <div class=""blog-details-social"">
                                    <a href=""#""><i class=""fa fa-facebook""></i></a>
                                    <a href=""#""><i class=""fa fa-twitter""></i></a>
                                    <a href=""#""><i class=""fa fa-google-plus""></i></a>
 ");
            WriteLiteral(@"                                   <a href=""#""><i class=""fa fa-linkedin""></i></a>
                                    <a href=""#""><i class=""fa fa-envelope""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""related-blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title related-blog-title"">
                    <h2>Post You May Like</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog-item"">
                    <div class=""blog-item-pic"">
                        <img src=""assets/img/blog/blog-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9833, "\"", 9839, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 10598, "\"", 10604, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 11365, "\"", 11371, 0);
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

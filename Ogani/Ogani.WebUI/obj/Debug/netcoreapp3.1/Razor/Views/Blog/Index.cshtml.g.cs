#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Blog/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fbb1eb41bc597bb01aea052397857b41ff29466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.Blog.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbb1eb41bc597bb01aea052397857b41ff29466", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89a98e261c88b19f8eb839873589ad3c1edf0d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Blog/Index.cshtml"
  
    ViewBag.Title = "Index";

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fbb1eb41bc597bb01aea052397857b41ff294665013", async() => {
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
                    <h2>Blog</h2>
                    <div class=""breadcrumb-option"">
                        <a href=""index-2.html"">Home</a>
                        <span>Blog</span>
                    </div>
                </div>
            </div>
 ");
            WriteLiteral(@"       </div>
    </div>
</section>


<section class=""blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-5"">
                <div class=""blog-sidebar"">
                    <div class=""blog-sidebar-search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fbb1eb41bc597bb01aea052397857b41ff294668100", async() => {
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
            BeginWriteAttribute("alt", " alt=\"", 4182, "\"", 4188, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 4760, "\"", 4766, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 5336, "\"", 5342, 0);
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
            WriteLiteral(@""">
                <div class=""row"">
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""blog-item"">
                            <div class=""blog-item-pic"">
                                <img src=""assets/img/blog/blog-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6638, "\"", 6644, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-item-text"">
                                <ul>
                                    <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                                    <li><i class=""fa fa-comment-o""></i> 5</li>
                                </ul>
                                <h5><a href=""#"">6 ways to prepare breakfast for 30</a></h5>
                                <p>
                                    Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam
                                    quaerat
                                </p>
                                <a href=""#"" class=""blog-btn"">READ MORE <span class=""arrow_right""></span></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""blog-item"">
                            <div class=""blog-item-pic"">");
            WriteLiteral("\n                                <img src=\"assets/img/blog/blog-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7739, "\"", 7745, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-item-text"">
                                <ul>
                                    <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                                    <li><i class=""fa fa-comment-o""></i> 5</li>
                                </ul>
                                <h5><a href=""#"">Visit the clean farm in the US</a></h5>
                                <p>
                                    Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam
                                    quaerat
                                </p>
                                <a href=""#"" class=""blog-btn"">READ MORE <span class=""arrow_right""></span></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""blog-item"">
                            <div class=""blog-item-pic"">
   ");
            WriteLiteral("                             <img src=\"assets/img/blog/blog-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 8836, "\"", 8842, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-item-text"">
                                <ul>
                                    <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                                    <li><i class=""fa fa-comment-o""></i> 5</li>
                                </ul>
                                <h5><a href=""#"">Cooking tips make cooking simple</a></h5>
                                <p>
                                    Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam
                                    quaerat
                                </p>
                                <a href=""#"" class=""blog-btn"">READ MORE <span class=""arrow_right""></span></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""blog-item"">
                            <div class=""blog-item-pic"">
 ");
            WriteLiteral("                               <img src=\"assets/img/blog/blog-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 9935, "\"", 9941, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-item-text"">
                                <ul>
                                    <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                                    <li><i class=""fa fa-comment-o""></i> 5</li>
                                </ul>
                                <h5><a href=""#"">Cooking tips make cooking simple</a></h5>
                                <p>
                                    Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam
                                    quaerat
                                </p>
                                <a href=""#"" class=""blog-btn"">READ MORE <span class=""arrow_right""></span></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""blog-item"">
                            <div class=""blog-item-pic"">
 ");
            WriteLiteral("                               <img src=\"assets/img/blog/blog-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 11034, "\"", 11040, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-item-text"">
                                <ul>
                                    <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                                    <li><i class=""fa fa-comment-o""></i> 5</li>
                                </ul>
                                <h5><a href=""#"">The Moment You Need To Remove Garlic From The Menu</a></h5>
                                <p>
                                    Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam
                                    quaerat
                                </p>
                                <a href=""#"" class=""blog-btn"">READ MORE <span class=""arrow_right""></span></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""blog-item"">
                            <div class=");
            WriteLiteral("\"blog-item-pic\">\n                                <img src=\"assets/img/blog/blog-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12151, "\"", 12157, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-item-text"">
                                <ul>
                                    <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                                    <li><i class=""fa fa-comment-o""></i> 5</li>
                                </ul>
                                <h5><a href=""#"">Cooking tips make cooking simple</a></h5>
                                <p>
                                    Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam
                                    quaerat
                                </p>
                                <a href=""#"" class=""blog-btn"">READ MORE <span class=""arrow_right""></span></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""product-pagination blog-pagination"">
                            <a href=""#"">1</a>
   ");
            WriteLiteral(@"                         <a href=""#"">2</a>
                            <a href=""#"">3</a>
                            <a href=""#""><i class=""fa fa-long-arrow-right""></i></a>
                        </div>
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

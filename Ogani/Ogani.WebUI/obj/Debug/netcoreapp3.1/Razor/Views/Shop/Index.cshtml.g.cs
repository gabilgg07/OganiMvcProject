#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0517fce954428662dbc3b146bf8888c4cf6fdcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.Shop.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0517fce954428662dbc3b146bf8888c4cf6fdcb", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b731d2a1c19d2c61f2c786dd2cef5d63154b374", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedViewModel<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-item-details-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
  
    ViewBag.Title = "Shop Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""breadcrumb-section set-bg"" data-setbg=""assets/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb-text"">
                    <h2>Organi Shop</h2>
                    <div class=""breadcrumb-option"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0517fce954428662dbc3b146bf8888c4cf6fdcb6104", async() => {
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
            WriteLiteral(@"
                        <span>Shop</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-5"">
                <div class=""sidebar"">
                    <div class=""sidebar-item"">
                        <h4>Department</h4>
                        ");
#nullable restore
#line 31 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
                   Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <div class=""sidebar-item"">
                        <h4>Price</h4>
                        <div class=""price-range-wrap"">
                            <div class=""price-range ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content"" data-min=""10"" data-max=""540"">
                                <div class=""ui-slider-range ui-corner-all ui-widget-header""></div>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                            </div>
                            <div class=""range-slider"">
                                <div class=""price-input"">
                                    <input type=""text"" id=""minamount"">
                                    <input type=""text"" id=""maxamount"">
                                </div>
                            </div>
      ");
            WriteLiteral(@"                  </div>
                    </div>
                    <div class=""sidebar-item sidebar-item-color--option"">
                        <h4>Colors</h4>
                        <div class=""sidebar-item-color sidebar-item-color--white"">
                            <label for=""white"">
                                White
                                <input type=""radio"" id=""white"">
                            </label>
                        </div>
                        <div class=""sidebar-item-color sidebar-item-color--gray"">
                            <label for=""gray"">
                                Gray
                                <input type=""radio"" id=""gray"">
                            </label>
                        </div>
                        <div class=""sidebar-item-color sidebar-item-color--red"">
                            <label for=""red"">
                                Red
                                <input type=""radio"" id=""red"">
                            </label");
            WriteLiteral(@">
                        </div>
                        <div class=""sidebar-item-color sidebar-item-color--black"">
                            <label for=""black"">
                                Black
                                <input type=""radio"" id=""black"">
                            </label>
                        </div>
                        <div class=""sidebar-item-color sidebar-item-color--blue"">
                            <label for=""blue"">
                                Blue
                                <input type=""radio"" id=""blue"">
                            </label>
                        </div>
                        <div class=""sidebar-item-color sidebar-item-color--green"">
                            <label for=""green"">
                                Green
                                <input type=""radio"" id=""green"">
                            </label>
                        </div>
                    </div>
                    <div class=""sidebar-item"">
                  ");
            WriteLiteral(@"      <h4>Popular Size</h4>
                        <div class=""sidebar-item-size"">
                            <label for=""large"">
                                Large
                                <input type=""radio"" id=""large"">
                            </label>
                        </div>
                        <div class=""sidebar-item-size"">
                            <label for=""medium"">
                                Medium
                                <input type=""radio"" id=""medium"">
                            </label>
                        </div>
                        <div class=""sidebar-item-size"">
                            <label for=""small"">
                                Small
                                <input type=""radio"" id=""small"">
                            </label>
                        </div>
                        <div class=""sidebar-item-size"">
                            <label for=""tiny"">
                                Tiny
                               ");
            WriteLiteral(@" <input type=""radio"" id=""tiny"">
                            </label>
                        </div>
                    </div>
                    <div class=""sidebar-item"">
                        <div class=""latest-product-text"">
                            ");
#nullable restore
#line 117 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
                       Write(await Component.InvokeAsync("SpecialProducts", new
                           {
                               caption = "Latest Products",
                               reportType = ProductReportType.Latest
                           }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9 col-md-7"">
                <div class=""product-discount"">
                    <div class=""section-title product-discount-title"">
                        <h2>Sale Off</h2>
                    </div>
                    <div class=""row"">
                        <div class=""product-discount-slider owl-carousel"">
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
                                    <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-1.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i cl");
            WriteLiteral(@"ass=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                        <span>Dried Fruit</span>
                                        <h5><a href=""#"">Raisin’n’nuts</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
                                    <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-2.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
            ");
            WriteLiteral(@"                            <ul class=""product-item-pic-hover"">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                        <span>Vegetables</span>
                                        <h5><a href=""#"">Vegetables’package</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
    ");
            WriteLiteral(@"                                <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-3.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                        <span>Dried Fruit</span>
                                        <h5><a href=""#"">Mixed Fruitss</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
              ");
            WriteLiteral(@"                      </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
                                    <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-4.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                     ");
            WriteLiteral(@"   <span>Dried Fruit</span>
                                        <h5><a href=""#"">Raisin’n’nuts</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
                                    <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-5.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shoppi");
            WriteLiteral(@"ng-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                        <span>Dried Fruit</span>
                                        <h5><a href=""#"">Raisin’n’nuts</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
                                    <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-6.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
                                            <li><a h");
            WriteLiteral(@"ref=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                        <span>Dried Fruit</span>
                                        <h5><a href=""#"">Raisin’n’nuts</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""filter-item"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-5"">
                          ");
            WriteLiteral("  <div class=\"filter-sort\">\n                                <span>Sort By</span>\n                                <select>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0517fce954428662dbc3b146bf8888c4cf6fdcb22043", async() => {
                WriteLiteral("Default");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0517fce954428662dbc3b146bf8888c4cf6fdcb23222", async() => {
                WriteLiteral("Default");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4"">
                            <div class=""filter-found"">
                                <h6><span>");
#nullable restore
#line 251 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
                                     Write(Model.TotalCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> Products found</h6>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-3"">
                            <div class=""filter-option"">
                                <span class=""icon_grid-2x2""></span>
                                <span class=""icon_ul""></span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
");
#nullable restore
#line 263 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
                     foreach (var item in Model.Items)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-6 col-sm-6\">\n                            <div class=\"product-item\">\n                                <div class=\"product-item-pic set-bg\" data-setbg=\"/uploads/images/products/");
#nullable restore
#line 267 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
                                                                                                     Write(item.Images?.FirstOrDefault(i=>i.IsMain)?.ImagePath);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                    <ul class=""product-item-pic-hover"">
                                        <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                        <li><a href=""#""");
            BeginWriteAttribute("onclick", " onclick=\"", 15433, "\"", 15468, 3);
            WriteAttributeValue("", 15443, "addToCard(event,", 15443, 16, true);
#nullable restore
#line 271 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
WriteAttributeValue("", 15459, item.Id, 15459, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 15467, ")", 15467, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a></li>\n                                    </ul>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0517fce954428662dbc3b146bf8888c4cf6fdcb27281", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 273 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n                                <div class=\"product-item-text\">\n                                    <h6>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0517fce954428662dbc3b146bf8888c4cf6fdcb29669", async() => {
#nullable restore
#line 276 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 276 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\n                                    <h5>$");
#nullable restore
#line 277 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
                                    Write(item.Price.ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                </div>\n                            </div>\n                        </div>\n");
#nullable restore
#line 281 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                ");
#nullable restore
#line 283 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Views/Shop/Index.cshtml"
           Write(Model.GetPagination(Url, "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</section>\n\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\n    <script");
                BeginWriteAttribute("class", " class=\"", 16252, "\"", 16260, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        function addToCard(ev, id) {
            ev.preventDefault();

            let arr = [];
            var storedJson = $.cookie('basket');

            if (storedJson != undefined && typeof storedJson == 'string') {
                arr = JSON.parse(storedJson);
            }

            var found = arr.filter(item => {
                return item.productId == id;
            })[0];

            if (found == undefined) {
                found = {
                    productId: id,
                    count: 1
                };
                arr.push(found);
            } else {
                found.count++;
            }

            var jsonStrinfy = JSON.stringify(arr);

            $.cookie('basket', jsonStrinfy, { expires: 60, path: '/' });

            showBasketCount();
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedViewModel<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

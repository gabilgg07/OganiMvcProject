#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Shared/_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "330ff0959f8ef6bf3c902d3b9cff37c7305bf284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.Shared.Areas_Admin_Views_Shared__SideBar), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_SideBar.cshtml")]
namespace Ogani.WebUI.Views.Shared
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
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.AppCode.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiMvcProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.AppCode.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330ff0959f8ef6bf3c902d3b9cff37c7305bf284", @"/Areas/Admin/Views/Shared/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b731d2a1c19d2c61f2c786dd2cef5d63154b374", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blogs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<p class=""menu-title sm"">BROWSE <span class=""pull-right""><a href=""javascript:;""><i class=""material-icons"">refresh</i></a></span></p>
<ul>
    <li class=""start "">
        <a href=""index.html""><i class=""material-icons"">home</i> <span class=""title"">Dashboard</span> <span class=""selected""></span> <span class=""arrow ""></span> </a>
        <ul class=""sub-menu"">
            <li> <a href=""dashboard_v1.html""> Dashboard v1 </a> </li>
            <li");
            BeginWriteAttribute("class", " class=\"", 446, "\"", 454, 0);
            EndWriteAttribute();
            WriteLiteral("> <a href=\"index.html \"> Dashboard v2 <span class=\" label label-info pull-right m-r-30\">NEW</span></a></li>\n        </ul>\n    </li>\n    <li>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "330ff0959f8ef6bf3c902d3b9cff37c7305bf2845657", async() => {
                WriteLiteral("\n            <i class=\"material-icons\">panorama_horizontal</i>\n            <span class=\"title\">Categories</span>\n        ");
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
            WriteLiteral("\n    </li>\n    <li>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "330ff0959f8ef6bf3c902d3b9cff37c7305bf2847149", async() => {
                WriteLiteral("\n            <i class=\"material-icons\">panorama_horizontal</i>\n            <span class=\"title\">Blogs</span>\n            <span class=\"label label-important bubble-only pull-right \"></span>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
    </li>
    <li>
        <a href=""email.html"">
            <i class=""material-icons"">email</i> <span class=""title"">Email</span> <span class="" badge badge-disable pull-right "">203</span>
        </a>
    </li>
    <li>
        <a href=""javascript:;""> <i class=""material-icons"">invert_colors</i> <span class=""title"">Themes</span> <span class="" arrow""></span> </a>
        <ul class=""sub-menu"">
            <li> <a href=""theme_coporate.html"">Coporate </a> </li>
            <li> <a href=""theme_simple.html"">Simple</a> </li>
            <li> <a href=""theme_elegant.html"">Elegant</a> </li>
        </ul>
    </li>
    <li>
        <a href=""javascript:;""> <i class=""material-icons"">airplay</i> <span class=""title"">Layouts</span> <span class="" arrow""></span> </a>
        <ul class=""sub-menu"">
            <li> <a href=""layout_options.html""> Layout Options </a> </li>
            <li> <a href=""boxed_layout.html"">Boxed Layout </a> </li>
            <li> <a href=""boxed_layout_v2.html"">Inner Boxed Layout </a> </li>
            <");
            WriteLiteral(@"li> <a href=""extended_layout.html"">Extended Layout</a> </li>
            <li> <a href=""RTL.html"">RTL Layout</a> </li>
            <li> <a href=""horizontal_menu.html"">Horizontal Menu</a> </li>
            <li> <a href=""horizontal_menu_boxed.html"">Horizontal Menu & Boxed</a> </li>
        </ul>
    </li>
    <li>
        <a href=""javascript:;""> <i class=""material-icons"">flip</i><span class=""title""> UI Elements</span> <span class="" arrow""></span> </a>
        <ul class=""sub-menu"">
            <li> <a href=""typography.html""> Typography </a> </li>
            <li> <a href=""messages_notifications.html""> Messages & Notifications </a> </li>
            <li> <a href=""notifications.html""> Notifications </a> </li>
            <li> <a href=""icons.html"">Icons</a> </li>
            <li");
            BeginWriteAttribute("class", " class=\"", 2858, "\"", 2866, 0);
            EndWriteAttribute();
            WriteLiteral(@"> <a href=""buttons.html"">Buttons</a> </li>
            <li> <a href=""tabs_accordian.html""> Tabs & Accordions </a> </li>
            <li> <a href=""sliders.html"">Sliders</a> </li>
            <li> <a href=""group_list.html"">Group list </a> </li>
        </ul>
    </li>
    <li>
        <a href=""javascript:;""> <i class=""material-icons"">view_stream</i> <span class=""title"">Forms</span> <span class="" arrow""></span> </a>
        <ul class=""sub-menu"">
            <li> <a href=""form_elements.html"">Form Elements </a> </li>
            <li> <a href=""form_validations.html"">Form Validations</a> </li>
        </ul>
    </li>
    <li>
        <a href=""javascript:;""> <i class=""material-icons"">apps</i> <span class=""title"">Grids</span> <span class="" arrow""></span> </a>
        <ul class=""sub-menu"">
            <li> <a href=""grids_simple.html"">Simple Grids</a> </li>
            <li> <a href=""grids_draggable.html"">Draggable Grids </a> </li>
        </ul>
    </li>
    <li>
        <a href=""javascript:;""> <i class=""material-icons""");
            WriteLiteral(@">playlist_add_check</i> <span class=""title"">Tables</span> <span class="" arrow""></span> </a>
        <ul class=""sub-menu"">
            <li> <a href=""tables.html""> Basic Tables </a> </li>
            <li> <a href=""datatables.html""> Data Tables </a> </li>
        </ul>
    </li>
    <li>
        <a href=""javascript:;""> <i class=""material-icons"">location_on</i> <span class=""title"">Maps</span> <span class="" arrow""></span> </a>
        <ul class=""sub-menu"">
            <li> <a href=""google_map.html""> Google Maps </a> </li>
            <li> <a href=""vector_map.html""> Vector Maps </a> </li>
        </ul>
    </li>
    <li>
        <a href=""charts.html""> <i class=""material-icons"">timeline</i> <span class=""title"">Charts</span> </a>
    </li>
    <li class=""open active"">
        <a href=""javascript:;""> <i class=""material-icons"">layers</i> <span class=""title"">Extra</span> <span class="" open  arrow""></span> </a>
        <ul class=""sub-menu"">
            <li> <a href=""user-profile.html""> User Profile </a> </li>
           ");
            WriteLiteral(" <li> <a href=\"time_line.html\"> Time line </a> </li>\n            <li> <a href=\"support_ticket.html\"> Support Ticket </a> </li>\n            <li> <a href=\"gallery.html\"> Gallery</a> </li>\n            <li");
            BeginWriteAttribute("class", " class=\"", 5116, "\"", 5124, 0);
            EndWriteAttribute();
            WriteLiteral(@"><a href=""calender.html""> Calendar</a> </li>
            <li> <a href=""search_results.html""> Search Results </a> </li>
            <li> <a href=""invoice.html""> Invoice </a> </li>
            <li> <a href=""404.html""> 404 Page </a> </li>
            <li> <a href=""500.html""> 500 Page </a> </li>
            <li> <a href=""blank_template.html""> Blank Page </a> </li>
            <li> <a href=""login.html""> Login </a> </li>
            <li> <a href=""login_v2.html"">Login v2</a> </li>
            <li> <a href=""lockscreen.html""> Lockscreen </a> </li>
        </ul>
    </li>
    <li");
            BeginWriteAttribute("class", " class=\"", 5701, "\"", 5709, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <a href=""javascript:;""> <i class=""material-icons"">more_horiz</i> <span class=""title"">Menu Levels</span> <span class="" arrow""></span> </a>
        <ul class=""sub-menu"">
            <li> <a href=""javascript:;""> Level 1 </a> </li>
            <li>
                <a href=""javascript:;""> <span class=""title"">Level 2</span> <span class="" arrow""></span> </a>
                <ul class=""sub-menu"">
                    <li> <a href=""javascript:;""> Sub Menu </a> </li>
                    <li> <a href=""ujavascript:;""> Sub Menu </a> </li>
                </ul>
            </li>
        </ul>
    </li>
    <li class=""hidden-lg hidden-md hidden-xs"" id=""more-widgets"">
        <a href=""javascript:;""> <i class=""material-icons""></i></a>
        <ul class=""sub-menu"">
            <li class=""side-bar-widgets"">
                <p class=""menu-title sm"">FOLDER <span class=""pull-right""><a href=""#"" class=""create-folder""><i class=""material-icons"">add</i></a></span></p>
                <ul class=""folders"">
                    <l");
            WriteLiteral(@"i>
                        <a href=""#"">
                            <div class=""status-icon green""></div>
                            My quick tasks
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <div class=""status-icon red""></div>
                            To do list
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <div class=""status-icon blue""></div>
                            Projects
                        </a>
                    </li>
                    <li class=""folder-input"" style=""display:none"">
                        <input type=""text"" placeholder=""Name of folder"" class=""no-boarder folder-name""");
            BeginWriteAttribute("name", " name=\"", 7546, "\"", 7553, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""folder-name"">
                    </li>
                </ul>
                <p class=""menu-title"">PROJECTS </p>
                <div class=""status-widget"">
                    <div class=""status-widget-wrapper"">
                        <div class=""title"">Freelancer<a href=""#"" class=""remove-widget""><i class=""material-icons"">close</i></a></div>
                        <p>Redesign home page</p>
                    </div>
                </div>
                <div class=""status-widget"">
                    <div class=""status-widget-wrapper"">
                        <div class=""title"">envato<a href=""#"" class=""remove-widget""><i class=""material-icons"">close</i></a></div>
                        <p>Statistical report</p>
                    </div>
                </div>
            </li>
        </ul>
    </li>
</ul>
<div class=""side-bar-widgets"">
    <p class=""menu-title sm"">FOLDER <span class=""pull-right""><a href=""#"" class=""create-folder""> <i class=""material-icons"">add</i></a></span></p>
    <ul class=""fold");
            WriteLiteral(@"ers"">
        <li>
            <a href=""#"">
                <div class=""status-icon green""></div>
                My quick tasks
            </a>
        </li>
        <li>
            <a href=""#"">
                <div class=""status-icon red""></div>
                To do list
            </a>
        </li>
        <li>
            <a href=""#"">
                <div class=""status-icon blue""></div>
                Projects
            </a>
        </li>
        <li class=""folder-input"" style=""display:none"">
            <input type=""text"" placeholder=""Name of folder"" class=""no-boarder folder-name""");
            BeginWriteAttribute("name", " name=\"", 9178, "\"", 9185, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </li>
    </ul>
    <p class=""menu-title"">PROJECTS </p>
    <div class=""status-widget"">
        <div class=""status-widget-wrapper"">
            <div class=""title"">Freelancer<a href=""#"" class=""remove-widget""><i class=""material-icons"">close</i></a></div>
            <p>Redesign home page</p>
        </div>
    </div>
    <div class=""status-widget"">
        <div class=""status-widget-wrapper"">
            <div class=""title"">envato<a href=""#"" class=""remove-widget""><i class=""material-icons"">close</i></a></div>
            <p>Statistical report</p>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

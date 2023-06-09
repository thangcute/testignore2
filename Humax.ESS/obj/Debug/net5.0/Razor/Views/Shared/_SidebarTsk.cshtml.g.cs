#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d581debd58e26e08e49f01446c84345ecc3e0fe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SidebarTsk), @"mvc.1.0.view", @"/Views/Shared/_SidebarTsk.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\_ViewImports.cshtml"
using Humax.ESS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\_ViewImports.cshtml"
using Humax.ESS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
using Humax.ESS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d581debd58e26e08e49f01446c84345ecc3e0fe9", @"/Views/Shared/_SidebarTsk.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__SidebarTsk : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
  
    var userInfo = Context.Session.GetCurrentUser();
    MenuItem.CurrentPath = Context.Request.Path;

    if (ViewBag.menuItems == null)
        ViewBag.menuItems = new List<MenuItem>()
        {
            new MenuItem { Text="Trang chủ", Path=Url.Action("Index", "Home"), SvgIcon="icon-home"},
            new MenuItem { 
                Text="Dự án",
                Path=Url.Action("Index", "TaskProject"),
                SvgIcon="icon-timesheets",
                SubMenu = new List<MenuItem>()
                {
                    new MenuItem{
                        Text="Bạn thực hiện",
                        Path=Url.Action("Index", "TaskProject"),
                        SvgIcon="icon-timesheets"
                    },
                    new MenuItem{
                        Text="Bạn quản trị",
                        Path=Url.Action("Index", "TaskProject"),
                        SvgIcon="icon-timesheets"
                    },
                    new MenuItem{
                        Text="Bạn theo dõi",
                        Path=Url.Action("Index", "TaskProject"),
                        SvgIcon="icon-timesheets"
                    },
                }
            },
            new MenuItem { 
                Text="Công việc",
                Path="/cong-viec",
                SvgIcon="icon-pay-slip",
                Class="stroke",
                SubMenu = new List<MenuItem>()
                {
                    new MenuItem{
                        Text="Bạn thực hiện",
                        Path="/cong-viec/1",
                        SvgIcon="icon-timesheets"
                    },
                    new MenuItem{
                        Text="Bạn đã giao",
                        Path="/cong-viec/2",
                        SvgIcon="icon-timesheets"
                    },
                    new MenuItem{
                        Text="Bạn theo dõi",
                        Path="/cong-viec/3",
                        SvgIcon="icon-timesheets"
                    },
                }
            },
            new MenuItem { 
                Text="Tiến độ",
                Path=Url.Action("Index", "TaskProgress"),
                SvgIcon="icon-kpi"
            },
            new MenuItem { 
                Text="Báo cáo",
                Path=Url.Action("Index", "TaskReport"),
                SvgIcon="icon-self-assessment"
            }
        };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a class=\"sidebar2__profile\"");
            BeginWriteAttribute("href", " href=\"", 2656, "\"", 2694, 1);
#nullable restore
#line 74 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
WriteAttributeValue("", 2663, Url.Action("Index", "Profile"), 2663, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"ava\"><img class=\"ava__pic\"");
            BeginWriteAttribute("src", " src=\"", 2740, "\"", 2767, 1);
#nullable restore
#line 75 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
WriteAttributeValue("", 2746, userInfo.AvatarUrl, 2746, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2768, "\"", 2774, 0);
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n    <div class=\"sidebar2__details\">\r\n        <div class=\"sidebar2__user\">");
#nullable restore
#line 77 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
                               Write(userInfo.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"sidebar2__login\">");
#nullable restore
#line 78 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
                                Write(userInfo.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</a>\r\n\r\n<div class=\"sidebar2__nav\">\r\n");
#nullable restore
#line 83 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
     foreach (MenuItem item in ViewBag.menuItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("class", " class=\"", 3065, "\"", 3120, 2);
            WriteAttributeValue("", 3073, "sidebar2__item", 3073, 14, true);
#nullable restore
#line 85 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
WriteAttributeValue(" ", 3087, item.IsActive ? "active" : "", 3088, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3121, "\"", 3138, 1);
#nullable restore
#line 85 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
WriteAttributeValue("", 3128, item.Path, 3128, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 86 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
             if (!string.IsNullOrEmpty(item.FaIcon))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i");
            BeginWriteAttribute("class", " class=\"", 3229, "\"", 3258, 3);
            WriteAttributeValue("", 3237, "icon", 3237, 4, true);
            WriteAttributeValue(" ", 3241, "fas", 3242, 4, true);
#nullable restore
#line 88 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
WriteAttributeValue(" ", 3245, item.FaIcon, 3246, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n");
#nullable restore
#line 89 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
            }
            else if (!string.IsNullOrEmpty(item.SvgIcon))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <svg");
            BeginWriteAttribute("class", " class=\"", 3375, "\"", 3420, 3);
            WriteAttributeValue("", 3383, "icon", 3383, 4, true);
            WriteAttributeValue(" ", 3387, "menu-item-icon", 3388, 15, true);
#nullable restore
#line 92 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
WriteAttributeValue(" ", 3402, item.Class??"", 3403, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <use");
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 3448, "\"", 3490, 2);
            WriteAttributeValue("", 3461, "/img/sprite.svg#", 3461, 16, true);
#nullable restore
#line 93 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
WriteAttributeValue("", 3477, item.SvgIcon, 3477, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></use>\r\n                </svg>\r\n");
#nullable restore
#line 95 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
            }
            else if (!string.IsNullOrEmpty(item.ImageIcon))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"icon\"");
            BeginWriteAttribute("src", " src=\"", 3648, "\"", 3669, 1);
#nullable restore
#line 98 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
WriteAttributeValue("", 3654, item.ImageIcon, 3654, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 99 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 100 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
       Write(T[item.Text]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 101 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
             if (item.Counter > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"sidebar2__counter\">");
#nullable restore
#line 103 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
                                          Write(item.Counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 104 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </a>\r\n");
#nullable restore
#line 106 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
         if (item.IsActive && item.SubMenu != null && item.SubMenu.Count > 0)
        {
            foreach (var _item in item.SubMenu)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"sidebar2__item_sub\"");
            BeginWriteAttribute("href", " href=\"", 4064, "\"", 4082, 1);
#nullable restore
#line 110 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
WriteAttributeValue("", 4071, _item.Path, 4071, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 111 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
               Write(_item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n");
#nullable restore
#line 113 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_SidebarTsk.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer T { get; private set; } = default!;
        #nullable disable
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

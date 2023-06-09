#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c992514039d8fe019ad7468d09d9d1562b199ea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Sidebar2), @"mvc.1.0.view", @"/Views/Shared/_Sidebar2.cshtml")]
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
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
using Humax.ESS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c992514039d8fe019ad7468d09d9d1562b199ea1", @"/Views/Shared/_Sidebar2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Sidebar2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
  
    MenuItem.CurrentPath = Context.Request.Path;

    if (ViewBag.menuItems == null)
        ViewBag.menuItems = new List<MenuItem>()
        {
            new MenuItem { Text="Trang chủ", Path=Url.Action("Index", "Home"), SvgIcon="icon-home"},
            new MenuItem { Text="Bảng công tháng", Path=Url.Action("Index", "Timesheet"), SvgIcon="icon-timesheets"},
            new MenuItem { Text="Bảng lương tháng", Path=Url.Action("Index", "PaySlip"), SvgIcon="icon-pay-slip", Class="stroke"},
            new MenuItem { Text="Đăng ký chỉ tiêu", Path=Url.Action("Registration", "Kpi"), SvgIcon="icon-kpi"},
            new MenuItem { Text="Tự đánh giá", Path=Url.Action("SelfAssessment", "Kpi"), SvgIcon="icon-self-assessment"},
            new MenuItem { Text="Đào tạo", Path=Url.Action("Index", "Training"), SvgIcon="icon-training"},
            new MenuItem { Text="Nhân viên", Path=Url.Action("Index", "Employee"), SvgIcon="icon-employees"},
        };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page4__sidebar\">\r\n    <nav class=\"page4__nav\">\r\n");
#nullable restore
#line 24 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
         foreach (var item in ViewBag.menuItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("class", " class=\"", 1243, "\"", 1295, 2);
            WriteAttributeValue("", 1251, "page4__item", 1251, 11, true);
#nullable restore
#line 26 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
WriteAttributeValue(" ", 1262, item.IsActive ? "active" : "", 1263, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1296, "\"", 1313, 1);
#nullable restore
#line 26 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
WriteAttributeValue("", 1303, item.Path, 1303, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 27 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
             if (!string.IsNullOrEmpty(item.FaIcon))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i");
            BeginWriteAttribute("class", " class=\"", 1404, "\"", 1433, 3);
            WriteAttributeValue("", 1412, "icon", 1412, 4, true);
            WriteAttributeValue(" ", 1416, "fas", 1417, 4, true);
#nullable restore
#line 29 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
WriteAttributeValue(" ", 1420, item.FaIcon, 1421, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n");
#nullable restore
#line 30 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
            }
            else if (!string.IsNullOrEmpty(item.SvgIcon))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <svg");
            BeginWriteAttribute("class", " class=\"", 1550, "\"", 1595, 3);
            WriteAttributeValue("", 1558, "icon", 1558, 4, true);
            WriteAttributeValue(" ", 1562, "menu-item-icon", 1563, 15, true);
#nullable restore
#line 33 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
WriteAttributeValue(" ", 1577, item.Class??"", 1578, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <use");
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 1623, "\"", 1665, 2);
            WriteAttributeValue("", 1636, "/img/sprite.svg#", 1636, 16, true);
#nullable restore
#line 34 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
WriteAttributeValue("", 1652, item.SvgIcon, 1652, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></use>\r\n                </svg>\r\n");
#nullable restore
#line 36 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
            }
            else if (!string.IsNullOrEmpty(item.ImageIcon))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"icon\"");
            BeginWriteAttribute("src", " src=\"", 1823, "\"", 1844, 1);
#nullable restore
#line 39 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
WriteAttributeValue("", 1829, item.ImageIcon, 1829, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 40 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 41 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
       Write(T[item.Text]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
             if (item.Counter > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"page4__counter\">");
#nullable restore
#line 44 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
                                       Write(item.Counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 45 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"page4__tooltip\">");
#nullable restore
#line 46 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
                                   Write(T[item.Text]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </a>\r\n");
#nullable restore
#line 48 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\_Sidebar2.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </nav>\r\n</div>");
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

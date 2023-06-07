#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\_DetailExperiences.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c24ec48f2e1e66b3acb5dc6b35bd0314efaa1b78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile__DetailExperiences), @"mvc.1.0.view", @"/Views/Profile/_DetailExperiences.cshtml")]
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
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\_DetailExperiences.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\_DetailExperiences.cshtml"
using Humax.ESS.Models.Profile.Experiences;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c24ec48f2e1e66b3acb5dc6b35bd0314efaa1b78", @"/Views/Profile/_DetailExperiences.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile__DetailExperiences : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExperienceModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\_DetailExperiences.cshtml"
Write(Html.DevExtreme().Form<ExperienceModel>()
    .ShowValidationSummary(false)
    .ID("form")
    .ColCount(12)
    .Items(items => {
        items.AddSimpleFor(m => m.KinhNghiemID)
                .ColSpan(12)
                .Label(l => l.Visible(false))
                .CssClass("hidden-control");

        items.AddSimpleFor(m => m.NoiLamViec)
                        .ColSpan(12)
                        .Label(e => e
                            .Text("Nơi làm việc")
                        )
                        .Editor(e => e
                            .TextBox()
                            .Placeholder("Nơi làm việc")
                            .Width("100%")
                            .Disabled(false)
                            .ReadOnly(true)
                        );

        items.AddSimpleFor(m => m.TuNgay)
            .ColSpan(6)
            .Label(e => e
                .Text("Ngày bắt đầu")
            )
            .Editor(e => e
                .DateBox()
                .ShowClearButton(true)
                .Width("100%")
                .DisplayFormat("dd-MM-yyyy")
                .ReadOnly(true)
            )
            .IsRequired(false);

        items.AddSimpleFor(m => m.ToiNgay)
            .ColSpan(6)
            .Label(e => e
                .Text("Ngày kết thúc")
            )
            .Editor(e => e
                .DateBox()
                .ShowClearButton(true)
                .Width("100%")
                .DisplayFormat("dd-MM-yyyy")
                .ReadOnly(true)
            )
            .IsRequired(false);

        items.AddSimpleFor(m => m.ChucVu)
                        .ColSpan(12)
                        .Label(e => e
                            .Text("Vị trí")
                        )
                        .Editor(e => e
                            .TextBox()
                            .Placeholder("Vị trí làm việc")
                            .Width("100%")
                            .Disabled(false)
                            .ReadOnly(true)
                        );

        items.AddSimpleFor(m => m.MucLuong)
            .ColSpan(6)
            .Label(e => e
                .Text("Mức lương")
            )
            .Editor(e => e
                .NumberBox()
                .Placeholder("Mức lương")
                .Max(10000000000)
                .Format("#,##0.##")//#0.##
                .ShowSpinButtons(true)
                .ShowClearButton(true)
                .Width("100%")
                .Disabled(false)
                .ReadOnly(true)
            );

        items.AddSimpleFor(m => m.NganhNgheID)
            .ColSpan(6)
            .Label(e => e
                .Text("Ngành nghề")
            )
            .Editor(e => e
                .SelectBox()
                .ShowClearButton(true)
                .Placeholder("Ngành nghề")
                .Width("100%")
                .Disabled(false)
                .DataSource(d => d.RemoteController()
                    .Key("Id")
                    .LoadUrl("/Category/GetCategoryByType?type=NS_DsNganhNghe")
                )
                .DisplayExpr("Name")
                .ValueExpr("Id")
                .ReadOnly(true)
            );
    }).FormData(Model)
);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExperienceModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

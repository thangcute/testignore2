#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\_DetailTrainingProcess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df3046e7f009f004b97e59c0373bba7b49829e59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile__DetailTrainingProcess), @"mvc.1.0.view", @"/Views/Profile/_DetailTrainingProcess.cshtml")]
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
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\_DetailTrainingProcess.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\_DetailTrainingProcess.cshtml"
using Humax.ESS.Models.Profile.TrainingProcess;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df3046e7f009f004b97e59c0373bba7b49829e59", @"/Views/Profile/_DetailTrainingProcess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile__DetailTrainingProcess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrainingProcessModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\_DetailTrainingProcess.cshtml"
Write(Html.DevExtreme().Form<TrainingProcessModel>()
    .ShowValidationSummary(false)
    .ID("form")
    .ColCount(12)
    .Items(items => {
        items.AddSimpleFor(m => m.QTDaoTaoID)
                .ColSpan(12)
                .Label(l => l.Visible(false))
                .CssClass("hidden-control");

        items.AddSimpleFor(m => m.LopDaoTao)
            .ColSpan(12)
            .Label(e => e
                .Text("Lớp đào tạo")
            )
            .Editor(e => e
                .TextBox()
                .Placeholder("Lớp đào tạo")
                .Width("100%")
                .Disabled(false)
                .ReadOnly(true)
            );

        items.AddSimpleFor(m => m.NoiDungDaoTao)
            .ColSpan(12)
            .Label(e => e
                .Text("Nội dung")
            )
            .Editor(e => e
                .TextBox()
                .Placeholder("Nội dung Đào tạo")
                .Width("100%")
                .Disabled(false)
                .ReadOnly(true)
            );

        items.AddSimpleFor(m => m.NoiDaoTao)
            .ColSpan(12)
            .Label(e => e
                .Text("Nơi Đào tạo")
            )
            .Editor(e => e
                .TextBox()
                .Placeholder("Nơi Đào tạo")
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

        items.AddSimpleFor(m => m.KhoaDaoTaoID)
            .ColSpan(6)
            .Label(e => e
                .Text("Chương trình")
            )
            .Editor(e => e
                .SelectBox()
                .ShowClearButton(true)
                .Placeholder("Chương trình")
                .Width("100%")
                .Disabled(false)
                .DataSource(d => d.RemoteController()
                    .Key("Id")
                    .LoadUrl("/Category/GetCategoryByType?type=NS_DT_KhoaDaoTao")
                )
                .DisplayExpr("Name")
                .ValueExpr("Id")
                .ReadOnly(true)
            );

        items.AddSimpleFor(m => m.HeDaoTaoID)
            .ColSpan(6)
            .Label(e => e
                .Text("Hệ Đào tạo")
            )
            .Editor(e => e
                .SelectBox()
                .ShowClearButton(true)
                .Placeholder("Hệ Đào tạo")
                .Width("100%")
                .Disabled(false)
                .DataSource(d => d.RemoteController()
                    .Key("Id")
                    .LoadUrl("/Category/GetCategoryByType?type=NS_DsHeDaoTao")
                )
                .DisplayExpr("Name")
                .ValueExpr("Id")
                .ReadOnly(true)
            );

        items.AddSimpleFor(m => m.NganhHocID)
            .ColSpan(6)
            .Label(e => e
                .Text("Ngành học")
            )
            .Editor(e => e
                .SelectBox()
                .ShowClearButton(true)
                .Placeholder("Ngành học")
                .Width("100%")
                .Disabled(false)
                .DataSource(d => d.RemoteController()
                    .Key("Id")
                    .LoadUrl("/Category/GetCategoryByType?type=NS_DsNganhHoc")
                )
                .DisplayExpr("Name")
                .ValueExpr("Id")
                .ReadOnly(true)
            );

        items.AddSimpleFor(m => m.ChuyenNganhID)
            .ColSpan(6)
            .Label(e => e
                .Text("Chuyên ngành")
            )
            .Editor(e => e
                .SelectBox()
                .ShowClearButton(true)
                .Placeholder("Chuyên ngành")
                .Width("100%")
                .Disabled(false)
                .DataSource(d => d.RemoteController()
                    .Key("Id")
                    .LoadUrl("/Category/GetCategoryByType?type=NS_DsChuyenNganh")
                )
                .DisplayExpr("Name")
                .ValueExpr("Id")
                .ReadOnly(true)
            );

        items.AddSimpleFor(m => m.VanBangID)
            .ColSpan(6)
            .Label(e => e
                .Text("Bằng cấp")
            )
            .Editor(e => e
                .SelectBox()
                .ShowClearButton(true)
                .Placeholder("Bằng cấp")
                .Width("100%")
                .Disabled(false)
                .DataSource(d => d.RemoteController()
                    .Key("Id")
                    .LoadUrl("/Category/GetCategoryByType?type=NS_DsVanBang")
                )
                .DisplayExpr("Name")
                .ValueExpr("Id")
                .ReadOnly(true)
            );

        items.AddSimpleFor(m => m.ChungChiID)
            .ColSpan(6)
            .Label(e => e
                .Text("Chứng chỉ")
            )
            .Editor(e => e
                .SelectBox()
                .ShowClearButton(true)
                .Placeholder("Chứng chỉ")
                .Width("100%")
                .Disabled(false)
                .DataSource(d => d.RemoteController()
                    .Key("Id")
                    .LoadUrl("/Category/GetCategoryByType?type=NS_DsChungChi")
                )
                .DisplayExpr("Name")
                .ValueExpr("Id")
                .ReadOnly(true)
            );

        items.AddSimpleFor(m => m.KetQuaDaoTaoID)
            .ColSpan(6)
            .Label(e => e
                .Text("Kết quả")
            )
            .Editor(e => e
                .SelectBox()
                .ShowClearButton(true)
                .Placeholder("Kết quả")
                .Width("100%")
                .Disabled(false)
                .DataSource(d => d.RemoteController()
                    .Key("Id")
                    .LoadUrl("/Category/GetCategoryByType?type=NS_DT_KetQuaDaoTao")
                )
                .DisplayExpr("Name")
                .ValueExpr("Id")
                .ReadOnly(true)
            );

        items.AddSimpleFor(m => m.DiemSo)
            .ColSpan(6)
            .Label(e => e
                .Text("Điểm số")
            )
            .Editor(e => e
                .NumberBox()
                .Placeholder("Điểm số")
                .Max(10)
                .Format("#,##0.##")
                .ShowSpinButtons(true)
                .ShowClearButton(true)
                .Width("100%")
                .Disabled(false)
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrainingProcessModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

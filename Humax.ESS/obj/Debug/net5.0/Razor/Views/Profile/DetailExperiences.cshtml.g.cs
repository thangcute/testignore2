#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\DetailExperiences.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b46cdf5366c64d46ff265b80bdd919742049f4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_DetailExperiences), @"mvc.1.0.view", @"/Views/Profile/DetailExperiences.cshtml")]
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
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\DetailExperiences.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\DetailExperiences.cshtml"
using Humax.ESS.Models.Profile.Experiences;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b46cdf5366c64d46ff265b80bdd919742049f4b", @"/Views/Profile/DetailExperiences.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_DetailExperiences : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExperienceModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formSubmit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<script>
    $(function () {
        $('#formSubmit').submit(function (e) {
            e.preventDefault();

            var _action = $('form#formSubmit').attr('action');
            var _data = $('form#formSubmit').serializeArray();

            $.ajax({
                dataType: 'json',
                type: 'POST',
                url: _action,
                data: _data,
                success: function (res, status, jqXHR) {
                    //console.log(res);
                    if (res.success == 1) {
                        toastr.success(""Thực hiện thành công"");

                        if ($('#gridContainer').length)
                            $(""#gridContainer"").dxDataGrid('instance').refresh();

                        ClosePopup();
                    } else if (res.success == 99) {
                        toastr.warning(""Dữ liệu không đúng định dạng"");
                        console.log(res.validation);
                    } else {
                        toa");
            WriteLiteral(@"str.warning(""Có lỗi trong quá trình xử lý"");
                    }
                },
                error: function (jqXHR, status, err) {
                    toastr.error(""Lỗi Server"");
                },
                complete: function () {
                    //$(""body"").removeClass(""loading"");
                }
            });
        });
    });
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b46cdf5366c64d46ff265b80bdd919742049f4b5973", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 47 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\DetailExperiences.cshtml"
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
            );

        items.AddSimpleFor(m => m.LyDoNghiViec)
                        .ColSpan(12)
                        .Label(e => e
                            .Text("Lý do nghỉ")
                        )
                        .Editor(e => e
                            .TextArea()
                            .Placeholder("Lý do nghỉ việc")
                            .Width("100%")
                            .Height(65)
                            .Disabled(false)
                        );
    }).FormData(Model)
    );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <button class=\"group__btn btn btn_blue flr mgt-10 mgr-0\" type=\"submit\">\r\n        <i class=\"icon dx-icon-check\"></i>");
#nullable restore
#line 158 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\DetailExperiences.cshtml"
                                     Write(T["Lưu"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </button>\r\n\r\n    <button class=\"group__btn btn btn_yellow flr mgt-10 mgr-6\" type=\"button\" onclick=\"ClosePopup();\">\r\n        <i class=\"icon dx-icon-close\"></i>");
#nullable restore
#line 162 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\DetailExperiences.cshtml"
                                     Write(T["Đóng"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\DetailExperiences.cshtml"
AddHtmlAttributeValue("", 1592, Url.Action("PostExperiences", "Profile"), 1592, 41, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79e74d4c898b0395cbc3291275233c7167484d8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_TrainingProcess), @"mvc.1.0.view", @"/Views/Profile/TrainingProcess.cshtml")]
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
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
using Humax.ESS.Models.Profile.TrainingProcess;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e74d4c898b0395cbc3291275233c7167484d8e", @"/Views/Profile/TrainingProcess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_TrainingProcess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/devextreme/dx-site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/devextreme/dx-site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
  
    ViewData["Title"] = T["Quá trình đào tạo"];
    string errorMessage = null;
    if (ViewData["ErrorMessage"] != null)
        errorMessage = ViewData["ErrorMessage"].ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79e74d4c898b0395cbc3291275233c7167484d8e5519", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e74d4c898b0395cbc3291275233c7167484d8e6633", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    function OpenPopup(_id, _title = \'\', _approve = 0) {\r\n        var __title = _title != \'\' ? _title : \'");
#nullable restore
#line 16 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                                          Write(T["Thêm mới Quá trình Đào tạo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        var __url = '/Profile/DetailTrainingProcess';
        var __popup = 'popup';
        var __data = {
            id: _id,
            approve: _approve
        };
        FormDetail(_id, __title, __url, __popup, __data);
    }

    // Hien thi html trang thai xet duyet
    function cellTempApproveStatus(container, options) {
        var _data = options.data;
        $(""<div />"").html(_data.ApproveStatusDisplay).appendTo(container);
    }

    // Xoa thong tin
    function jsDelete(e) {
        // success-info-warning-error
        var _data = e.row.data;
        var _QTDaoTaoID = _data.QTDaoTaoID;
        var _XetDuyet = _data.XetDuyet;

        if (typeof _QTDaoTaoID != 'undefined' && _QTDaoTaoID > 0) {
            if (_XetDuyet == null || _XetDuyet == 0) {
                Confirm(""Bạn muốn tiếp tục thực hiện thao tác ?"").show().done(function (dialogResult) {
                    if (dialogResult.status) {
                        $.ajax({
                            url: ");
            WriteLiteral(@"'/Profile/DeleteTrainingProcess',
                            //contentType: ""application/json"",
                            dataType: ""json"",
                            type: 'POST',
                            async: false,
                            data: {
                                id: _QTDaoTaoID
                            },
                            success: function (response, status, jqXHR) {
                                console.log(response);
                                if (response.success == 1) {
                                    toastr.success(""Xóa Quá trình Đạo tạo thành công !"");

                                    if ($('#gridContainer').length)
                                        $(""#gridContainer"").dxDataGrid('instance').refresh();
                                }
                                else
                                    toastr.warning(response.message);
                            },
                            error: function (jqX");
            WriteLiteral(@"HR, status, err) {
                                toastr.warning(""Lỗi xử lý !"");
                            },
                            complete: function (jqXHR, status) {
                            }
                        });
                    } else
                        toastr.warning(""Bạn đã hủy thao táo !"");
                });
            } else
                toastr.warning(""Bạn không thể xóa dữ liệu này !"");
        } else
            toastr.warning(""Không có thông tin chọn !"");
    }

    // Sua thong tin
    function jsEdit(e) {
        var _data = e.row.data;
        var _QTDaoTaoID = _data.QTDaoTaoID;
        var _LopDaoTao = _data.LopDaoTao;
        var _XetDuyet = _data.XetDuyet;
        if (typeof _XetDuyet == 'undefined' || _XetDuyet == null)
            _XetDuyet = 0;

        if (typeof _QTDaoTaoID != 'undefined' && _QTDaoTaoID > 0) {
            OpenPopup(_QTDaoTaoID, _LopDaoTao, _XetDuyet);
        } else
            toastr.warning(""Không có thông t");
            WriteLiteral("in chọn\");\r\n    }\r\n</script>\r\n\r\n<div class=\"sorting1\">\r\n    <div class=\"sorting1__row\">\r\n        <h1 class=\"sorting1__title title\">");
#nullable restore
#line 96 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                                     Write(T["Quá trình đào tạo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 97 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
         if (!string.IsNullOrEmpty(errorMessage))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"error-messsage\">");
#nullable restore
#line 99 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                                   Write(errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 100 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"sorting1__options\">\r\n            <div class=\"sorting1__search js-sorting-search\">\r\n                <button class=\"group__btn btn btn_blue\" onClick=\"OpenPopup(0, \'\');\">\r\n                    <i class=\"icon dx-icon-plus\"></i>");
#nullable restore
#line 104 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                                                Write(T["Đăng ký"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"content-block\">\r\n    ");
#nullable restore
#line 112 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
Write(Html.DevExtreme().DataGrid<TrainingProcessListModel>()
        .ID("gridContainer")
        .DataSource(d => d.Mvc()
            .Controller("Profile")
            .LoadAction("GetTrainingProcess")
            .Key("QTDaoTaoID")
        )
        .DateSerializationFormat("yyyy-MM-dd HH:mm:ss")
        .ShowBorders(true)
        .ShowRowLines(true)
        .ShowColumnLines(true)
        .ColumnAutoWidth(true)
        .ColumnHidingEnabled(true)
        .RowAlternationEnabled(true)
        .Columns(columns => {
            columns.Add().Caption("No").Alignment(HorizontalAlignment.Center).CellTemplate(new JS("dataGrid_rowIndex_cellTemplate")).Width(80);
            columns.Add().Caption(T["Thời gian Làm việc"].Value).CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                <div>");
#nullable restore
#line 129 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                Write(T["Lớp đào tạo"]);

#line default
#line hidden
#nullable disable
    WriteLiteral(": <span class=\"dev-grid-title\"><%- (data.LopDaoTao");
    BeginWriteAttribute("!", " !=", 5219, "", 5222, 0);
    EndWriteAttribute();
    WriteLiteral(" null ? data.LopDaoTao : \"\") %></span></div>\r\n                <div>");
#nullable restore
#line 130 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                Write(T["Nơi đào tạo"]);

#line default
#line hidden
#nullable disable
    WriteLiteral(": <span class=\"dev-grid-title\"><%- data.NoiDaoTao %></span></div>\r\n                <div>");
#nullable restore
#line 131 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                Write(T["Từ ngày"]);

#line default
#line hidden
#nullable disable
    WriteLiteral(": <span class=\"dev-grid-start-time\"><%- data.FromDateDisplay %></span> - ");
#nullable restore
#line 131 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                                                                                                      Write(T["Đến ngày"]);

#line default
#line hidden
#nullable disable
    WriteLiteral(": <span class=\"dev-grid-end-time\"><%- data.ToDateDisplay %></span></div>\r\n            ");
    PopWriter();
}
));
            columns.Add().Caption(T["Vị trí công tác"].Value).CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                <div>");
#nullable restore
#line 134 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                Write(T["Số tháng cam kết"]);

#line default
#line hidden
#nullable disable
    WriteLiteral(": <span class=\"dev-grid-start-time\"><%- data.CommitMonthDisplay %></span></div>\r\n                <div>");
#nullable restore
#line 135 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                Write(T["Ngày Cam kết"]);

#line default
#line hidden
#nullable disable
    WriteLiteral(": <span class=\"dev-grid-start-time\"><%- data.CommitDateDisplay %></span></div>\r\n                <div>");
#nullable restore
#line 136 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
                Write(T["Kết quả"]);

#line default
#line hidden
#nullable disable
    WriteLiteral(": <span class=\"dev-grid-start-time\"><%-");
    BeginWriteAttribute("data.TenKetQuaDaoTao", " data.TenKetQuaDaoTao=", 5991, "", 6013, 0);
    EndWriteAttribute();
    WriteLiteral("=null ? \"\" : data.TenKetQuaDaoTao %></span></div>\r\n            ");
    PopWriter();
}
));
            columns.AddFor(m => m.GhiChu).Caption("Ghi chú");
            columns.Add().Caption(T["Trạng thái"].Value).CellTemplate(new JS("cellTempApproveStatus")).Width(160);
            columns.Add().Caption(T["#"].Value)
            .Type(GridCommandColumnType.Buttons)
            .Width(80)
            .Buttons(b =>
            {
                b.Add().Icon("edit").OnClick("jsEdit");
                b.Add().Icon("trash").OnClick("jsDelete");
            });
        })
        .Paging(p => p.PageSize(20))
        .Pager(p => p
            .Visible(true)
            .ShowPageSizeSelector(false)
            .ShowInfo(true)
            .InfoText(new JS("gridInfoText"))
            .ShowNavigationButtons(true)
        )
    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 158 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Profile\TrainingProcess.cshtml"
Write(Html.DevExtreme().Popup()
        .ID("popup")
        //.Width(300)
        //.Height('auto')
        .ShowTitle(true)
        .Title("Thêm mới Quá trình Đào tạo")
        .Visible(false)
        .DragEnabled(false)
        .CloseOnOutsideClick(true)
    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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

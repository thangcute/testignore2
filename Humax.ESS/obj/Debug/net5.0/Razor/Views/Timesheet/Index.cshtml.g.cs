#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb3c457371b132b09939ae77344c58a31745bdfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Timesheet_Index), @"mvc.1.0.view", @"/Views/Timesheet/Index.cshtml")]
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
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
using Humax.ESS.Models.Timesheet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb3c457371b132b09939ae77344c58a31745bdfe", @"/Views/Timesheet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Timesheet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 4 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
  
    ViewData["Title"] = T["Bảng công tháng"];
    string errorMessage = null;
    if (ViewData["ErrorMessage"] != null)
        errorMessage = ViewData["ErrorMessage"].ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb3c457371b132b09939ae77344c58a31745bdfe5439", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb3c457371b132b09939ae77344c58a31745bdfe6553", async() => {
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
            WriteLiteral(@"

<script>
    function calcCellValue(e) {
        //console.log(e);
    }

    function cellTempDienGiai(container, options) {
        var _data = options.data;
        var _htmlStr = """"
        $(""<div />"").html(_htmlStr).appendTo(container);
    }

    function jsGiaiTrinhThemGio(e) {
        var _element = e.element;
        if (typeof _element != 'undefined' && _element != null && typeof _element[0].attributes.ngaychamcong != 'undefined' && _element[0].attributes.ngaychamcong != null) {
            var _ngaychamcong = _element[0].attributes.ngaychamcong.value;

            if (typeof _ngaychamcong != 'undefined' && _ngaychamcong != '') {
                var _date = new Date(_ngaychamcong);
                if (typeof _date != 'undefined' && _date != null) {
                    var _year = _date.getFullYear(), _month = _date.getMonth() + 1, _day = _date.getDate();
                    var __NgayChamCong = `${_year}-${_month}-${_day}`;

                    var __id = ""popup"";
       ");
            WriteLiteral("             var __title = \'");
#nullable restore
#line 37 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
                              Write(T["Giải trình thêm giờ"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + ` Ngày: ${(_day > 9 ? _day : '0' + _day)}-${(_month > 9 ? _month : '0' + _month)}-${_year}`;
                    var __url = '/Timesheet/DetailLostFinger';
                    var __popup = 'popup';
                    var __data = {
                        date: __NgayChamCong
                    };
                    var __width = 500;
                    var __offset = 0;
                    FormDetail(__id, __title, __url, __popup, __data, __width, __offset);
                }
            }
        } else
            toastr.warning(""Không tìm thấy thông tin ngày công"");
    }

    function jsGiaiTrinhDiMuonVeSom(e) {
        var _element = e.element;
        var __isDimuon = false;
        if (typeof _element != 'undefined' && _element != null && typeof _element[0].attributes.ngaychamcong != 'undefined' && _element[0].attributes.ngaychamcong != null) {
            var _ngaychamcong = _element[0].attributes.ngaychamcong.value;

            if (typeof _element[0].attributes.dimuon ");
            WriteLiteral(@"!= 'undefined' && _element[0].attributes.dimuon != '') {
                var _dimuon = _element[0].attributes.dimuon.value;
                if (typeof _dimuon != 'undefined' && _dimuon != '')
                    __isDimuon = true;
            }

            if (typeof _ngaychamcong != 'undefined' && _ngaychamcong != '') {
                var _date = new Date(_ngaychamcong);
                if (typeof _date != 'undefined' && _date != null) {
                    var _year = _date.getFullYear(), _month = _date.getMonth() + 1, _day = _date.getDate();
                    var __NgayChamCong = `${_year}-${_month}-${_day}`;

                    var __id = ""popup"";
                    var __title = (__isDimuon != true ? '");
#nullable restore
#line 71 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
                                                    Write(T["Giải trình về sớm"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' : \'");
#nullable restore
#line 71 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
                                                                                Write(T["Giải trình đi muộn"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"') + ` Ngày: ${(_day > 9 ? _day : '0' + _day)}-${(_month > 9 ? _month : '0' + _month)}-${_year}`;
                    var __url = '/Timesheet/DetailExplain';
                    var __popup = 'popup';
                    var __data = {
                        date: __NgayChamCong,
                        isDimuon: __isDimuon
                    };
                    var __width = 500;
                    var __offset = 0;
                    FormDetail(__id, __title, __url, __popup, __data, __width, __offset);
                }
            }
        }
    }

    function contentReady(e) {
        $("".dx-datagrid-nodata"").hide();
    }

    var MonthTimeSheet = function () {
        var _MonthTimeSheet = $(""#MonthTimeSheet"").dxDateBox(""instance"").option(""value"");   //$(""#MonthTimeSheet"").dxDateBox(""option"", ""value"")
        if (typeof _MonthTimeSheet != 'undefined' && _MonthTimeSheet != '') {
            var _month = _MonthTimeSheet.getMonth() + 1;
            var _year = _MonthTimeShee");
            WriteLiteral(@"t.getFullYear();
            return _year + '-' + (_month > 9 ? _month : ('0' + _month));
        }
        return '';
    };

    $(function () {
        $('#btnSearch').click(function () {
            if ($('#gridTimeSheet').length)
                $(""#gridTimeSheet"").dxDataGrid('instance').refresh();

            if ($('#gridSummary').length)
                $(""#gridSummary"").dxDataGrid('instance').refresh();
        });
    });
</script>

<div class=""sorting1"">
    <div class=""sorting1__row"">
        <h1 class=""sorting1__title title"">");
#nullable restore
#line 113 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
                                     Write(T["Bảng công tháng"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"sorting1__form\">\r\n        <div class=\"sorting1__wrap\">\r\n            <div class=\"sorting1__fieldset\">\r\n                <div class=\"videos__field\">\r\n                    ");
#nullable restore
#line 119 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
                Write(Html.DevExtreme().DateBox()
                        .ID("MonthTimeSheet")
                        .ShowClearButton(true)
                        .DisplayFormat("MM-yyyy")
                        .Type(DateBoxType.Date)
                        .UseMaskBehavior(true)
                        .Value(DateTime.Now)
                    );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""sorting1__field"">
                    <button id=""btnSearch"" class=""sorting1__btn group__btn btn dx-button-mode-contained dx-button-success""><i class=""icon dx-icon-find""></i> Áp dụng</button>
                </div>
            </div>
        </div>
");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"content-block\">\r\n    <div>\r\n        <div class=\"page2__col page2__col_w65 ml-0 flt-left\">\r\n            ");
#nullable restore
#line 140 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
        Write(Html.DevExtreme().DataGrid<TimesheetModel>()
                .ID("gridTimeSheet")
                .DataSource(d => d.Mvc()
                    .Controller("Timesheet")
                    .LoadAction("Get")
                    .LoadParams(new { MonthTimeSheet = new JS("MonthTimeSheet") })
                    //.Key("TongHopTheoNgayID")
                )
                .DateSerializationFormat("yyyy-MM-dd HH:mm:ss")
                .ShowBorders(true)
                .ShowRowLines(true)
                .ShowColumnLines(true)
                .ColumnAutoWidth(true)
                .ColumnHidingEnabled(true)
                .RowAlternationEnabled(true)
                .Columns(columns => {
                    columns.Add().Caption(T["Ngày công"].Value).CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                        <div class=\"dev-grid-day-of-week <%- data.Thu %>\"><%- data.Thu %></div>\r\n                        <div class=\"dev-grid-day-of-month\"><%- data.NgayThang %></div>\r\n                    ");
    PopWriter();
}
)).Width(120).AllowSorting(false);
                    columns.Add().Caption(T["Thời gian"].Value).CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                        <div>\r\n                            <% if(data.TG_Den.trim() != \"00:00:00\" && data.TG_Den.trim()");
    BeginWriteAttribute("!", " != \"", 7259, "\"", 7264, 0);
    EndWriteAttribute();
    WriteLiteral(" && data.TG_Den");
    BeginWriteAttribute("!", " !=", 7280, "", 7283, 0);
    EndWriteAttribute();
    WriteLiteral(" null) { %>\r\n                                <span class=\"group__btn btn btn_blue-light p-t-3 p-b-3\"><%= data.TG_Den %></span>\r\n                            <% } %>\r\n\r\n                            <% if(data.TG_Ra.trim() != \"00:00:00\" && data.TG_Ra.trim()");
    BeginWriteAttribute("!", " != \"", 7536, "\"", 7541, 0);
    EndWriteAttribute();
    WriteLiteral(" && data.TG_Ra");
    BeginWriteAttribute("!", " !=", 7556, "", 7559, 0);
    EndWriteAttribute();
    WriteLiteral(" null) { %>\r\n                                <span class=\"group__btn btn btn_blue-light p-t-3 p-b-3\"><%= data.TG_Ra %></span>\r\n                            <% } %>\r\n\r\n                            <% if(data.TG_Vao.trim() != \"00:00:00\" && data.TG_Vao.trim()");
    BeginWriteAttribute("!", " != \"", 7813, "\"", 7818, 0);
    EndWriteAttribute();
    WriteLiteral(" && data.TG_Vao");
    BeginWriteAttribute("!", " !=", 7834, "", 7837, 0);
    EndWriteAttribute();
    WriteLiteral(" null) { %>\r\n                                <span class=\"group__btn btn btn_blue-light p-t-3 p-b-3\"><%= data.TG_Vao %></span>\r\n                            <% } %>\r\n\r\n                            <% if(data.TG_Ve.trim() != \"00:00:00\" && data.TG_Ve.trim()");
    BeginWriteAttribute("!", " != \"", 8090, "\"", 8095, 0);
    EndWriteAttribute();
    WriteLiteral(" && data.TG_Ve");
    BeginWriteAttribute("!", " !=", 8110, "", 8113, 0);
    EndWriteAttribute();
    WriteLiteral(" null) { %>\r\n                                <span class=\"group__btn btn btn_blue-light p-t-3 p-b-3\"><%= data.TG_Ve %></span>\r\n                            <% } %>\r\n\r\n                            <% if(data.NghiPhep_CongTac");
    BeginWriteAttribute("!", " != \"", 8334, "\"", 8339, 0);
    EndWriteAttribute();
    WriteLiteral(" && data.NghiPhep_CongTac");
    BeginWriteAttribute("!", " !=", 8365, "", 8368, 0);
    EndWriteAttribute();
    WriteLiteral(@" null) { %>
                                <p class=""mgb-6 mgt-6""><span class=""group__btn btn dx-button-mode-contained dx-button-danger p-t-3 p-b-3""><%= data.NghiPhep_CongTac %></span></p>
                            <% } %>

                            <% if(data.DangKy");
    BeginWriteAttribute("!", " != \"", 8644, "\"", 8649, 0);
    EndWriteAttribute();
    WriteLiteral(" && data.DangKy");
    BeginWriteAttribute("!", " !=", 8665, "", 8668, 0);
    EndWriteAttribute();
    WriteLiteral(" null) { %>\r\n                                <p class=\"mgb-6 mgt-6\"><span class=\"group__btn btn btn_yellow p-t-3 p-b-3\"><%= data.DangKy %></span></p>\r\n                            <% } %>\r\n                        </div>\r\n                    ");
    PopWriter();
}
)).Width(250).AllowSorting(false);
                    columns.Add().Caption(T["Ghi chú"].Value).CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                        <div>\r\n                            <p>\r\n                                <span");
    BeginWriteAttribute("class", " class=\"", 9135, "\"", 9143, 0);
    EndWriteAttribute();
    WriteLiteral(">Ca: <%= data.CaLamViec == null ? \"\" : data.CaLamViec %></span>\r\n                                 - <span");
    BeginWriteAttribute("class", " class=\"", 9249, "\"", 9257, 0);
    EndWriteAttribute();
    WriteLiteral(">CLV: <%= data.TG_LamViec == null ? 0 : data.TG_LamViec %></span>\r\n                                 - <span");
    BeginWriteAttribute("class", " class=\"", 9365, "\"", 9373, 0);
    EndWriteAttribute();
    WriteLiteral(">OT: <%= data.TG_LamThem == null ? 0 : data.TG_LamThem %></span>\r\n                            </p>\r\n\r\n                            <% if(data.DiMuon");
    BeginWriteAttribute("!", " !=", 9521, "", 9524, 0);
    EndWriteAttribute();
    WriteLiteral(@" null && data.DiMuon > 0) { %>
                                <p class=""mgt-6 mgb-6""><span class=""group__btn btn btn_yellow p-t-3 p-b-3"">Đi muộn: <%= data.DiMuon %> phút</span></p>
                            <% } %>

                            <% if(data.VeSom");
    BeginWriteAttribute("!", " !=", 9791, "", 9794, 0);
    EndWriteAttribute();
    WriteLiteral(@" null && data.VeSom > 0) { %>
                                <p class=""mgt-6 mgb-6""><span class=""group__btn btn btn_yellow p-t-3 p-b-3"">Về sớm: <%= data.VeSom %> phút</span></p>
                            <% } %>

                            <% if(data.GiaiTrinhDiMuon");
    BeginWriteAttribute("!", " !=", 10068, "", 10071, 0);
    EndWriteAttribute();
    WriteLiteral(" null && data.GiaiTrinhDiMuon");
    BeginWriteAttribute("!", " != \"", 10100, "\"", 10105, 0);
    EndWriteAttribute();
    WriteLiteral(" && data.DisableGiaiTrinhDiMuon");
    BeginWriteAttribute("!", " !=", 10137, "", 10140, 0);
    EndWriteAttribute();
    WriteLiteral(" null &&");
    BeginWriteAttribute("data.DisableGiaiTrinhDiMuon", " data.DisableGiaiTrinhDiMuon =", 10148, "", 10178, 0);
    EndWriteAttribute();
    WriteLiteral(@"= false) { %>
                                <p class=""mgt-6 mgb-6""><span class=""group__btn btn dx-button-mode-contained dx-button-success p-t-3 p-b-3""><%= data.GiaiTrinhDiMuon %></span></p>
                            <% } %>

                            <% if(data.GiaiTrinhVeSom");
    BeginWriteAttribute("!", " !=", 10464, "", 10467, 0);
    EndWriteAttribute();
    WriteLiteral(" null && data.GiaiTrinhVeSom");
    BeginWriteAttribute("!", " != \"", 10495, "\"", 10500, 0);
    EndWriteAttribute();
    WriteLiteral(" && data.DisableGiaiTrinhVeSom");
    BeginWriteAttribute("!", " !=", 10531, "", 10534, 0);
    EndWriteAttribute();
    WriteLiteral(" null &&");
    BeginWriteAttribute("data.DisableGiaiTrinhVeSom", " data.DisableGiaiTrinhVeSom =", 10542, "", 10571, 0);
    EndWriteAttribute();
    WriteLiteral("= false) { %>\r\n                                <p class=\"mgt-6 mgb-6\"><span class=\"group__btn btn btn_yellow p-t-3 p-b-3\"><%= data.GiaiTrinhVeSom %></span></p>\r\n                            <% } %>\r\n\r\n                            <% if(data.GiaiTrinhThemGio");
    BeginWriteAttribute("!", " !=", 10826, "", 10829, 0);
    EndWriteAttribute();
    WriteLiteral(" null && data.GiaiTrinhThemGio");
    BeginWriteAttribute("!", " != \"", 10859, "\"", 10864, 0);
    EndWriteAttribute();
    WriteLiteral(" && data.DisableGiaiThemGio");
    BeginWriteAttribute("!", " !=", 10892, "", 10895, 0);
    EndWriteAttribute();
    WriteLiteral(" null &&");
    BeginWriteAttribute("data.DisableGiaiThemGio", " data.DisableGiaiThemGio =", 10903, "", 10929, 0);
    EndWriteAttribute();
    WriteLiteral(@"= false) { %>
                                <p class=""mgt-6 mgb-6""><span class=""group__btn btn dx-button-mode-contained dx-button-danger p-t-3 p-b-3""><%= data.GiaiTrinhThemGio %></span></p>
                            <% } %>
                        </div>
                    ");
    PopWriter();
}
)).Width(300).AllowSorting(false); //new JS("cellTempDienGiai") //.CalculateCellValue("calcCellValue")
                    columns.AddFor(m => m.NgayChamCong).Caption(T["Giải trình"].Value).CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                        <div>\r\n                            <% if(\r\n                                (");
    BeginWriteAttribute("(data.GiaiTrinhDiMuon", "\r\n                                    (data.GiaiTrinhDiMuon =", 11531, "", 11592, 0);
    EndWriteAttribute();
    WriteLiteral(@"= null || data.GiaiTrinhDiMuon == """") && data.DiMuon != null && data.DiMuon > 0
                                ) || (
                                    (data.GiaiTrinhVeSom == null || data.GiaiTrinhVeSom == """") && data.VeSom != null && data.VeSom > 0
                                )
                            ) { %>
                            <p>
                                <% if(data.DiMuon");
    BeginWriteAttribute("!", " !=", 12002, "", 12005, 0);
    EndWriteAttribute();
    WriteLiteral(" null && data.DiMuon > 0 && data.DisableGiaiTrinhDiMuon != null && data.DisableGiaiTrinhDiMuon == false) { %>\r\n                                    ");
#nullable restore
#line 227 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
                                Write(Html.DevExtreme().Button()
                                        .Text("Giải trình đi muộn")
                                        .ElementAttr(new Dictionary<string, object>() {
                                            { "class", "group__btn btn btn_blue-light p-t-3 p-b-3 btn-giai-trinh" },
                                            { "NgayChamCong", new JS("data.NgayChamCong") },
                                            { "Dimuon", true }
                                        })
                                        .OnClick("jsGiaiTrinhDiMuonVeSom")
                                    );

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n                                <% } %>\r\n\r\n                                <% if(data.VeSom");
    BeginWriteAttribute("!", " !=", 12866, "", 12869, 0);
    EndWriteAttribute();
    WriteLiteral(" null && data.VeSom > 0 && data.DisableGiaiTrinhVeSom != null && data.DisableGiaiTrinhVeSom == false) { %>\r\n                                    ");
#nullable restore
#line 239 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
                                Write(Html.DevExtreme().Button()
                                        .Text("Giải trình về sớm")
                                        .ElementAttr(new Dictionary<string, object>() {
                                            { "class", "group__btn btn btn_yellow p-t-3 p-b-3 btn-giai-trinh" },
                                            { "NgayChamCong", new JS("data.NgayChamCong") }
                                        })
                                        .OnClick("jsGiaiTrinhDiMuonVeSom")
                                    );

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n                                <% } %>\r\n                            </p>\r\n                            <% } %>\r\n\r\n                            <% if(");
    BeginWriteAttribute("(data.DangKy", "\r\n                                (data.DangKy =", 13714, "", 13762, 0);
    EndWriteAttribute();
    WriteLiteral(@"= """" || data.DangKy == null) &&
                                (data.NghiPhep_CongTac == """" || data.NghiPhep_CongTac == null) &&
                                (data.TG_LamViec == 0 || data.TG_LamViec == null) &&
                                ((data.Thu != ""Sat"" && data.Thu != ""T7"") || ((data.Thu == ""Sat"" || data.Thu == ""T7"") && data.IsLamThubay)) &&
                                ((data.Thu != ""Sun"" && data.Thu != ""CN"") || ((data.Thu == ""Sun"" || data.Thu == ""CN"") && data.IsLamChuNhat)) &&
                                ((data.TG_Ve == """" || data.TG_Ve == ""00:00:00"" || data.TG_Ve == null) && (data.TG_Den == """" || data.TG_Den == ""00:00:00"" || data.TG_Den == null)) &&
                                (data.DisableGiaiThemGio != null && data.DisableGiaiThemGio == false)
                            ) { %>
                                ");
#nullable restore
#line 260 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
                            Write(Html.DevExtreme().Button()
                                    .Text("Giải trình thiếu giờ")
                                    .ElementAttr(new Dictionary<string, object>() {
                                        { "class", "group__btn btn dx-button-mode-contained dx-button-danger btn-giai-trinh" },
                                        { "NgayChamCong", new JS("data.NgayChamCong") }
                                    })
                                    .OnClick("jsGiaiTrinhThemGio")
                                );

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n                            <% } %>\r\n                        </div>\r\n                    ");
    PopWriter();
}
));
                })
                .OnContentReady("contentReady")
                .Paging(p => p.PageSize(100))
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"page2__col page2__col_w35 mr-0 flt-right\">\r\n            ");
#nullable restore
#line 277 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
        Write(Html.DevExtreme().DataGrid<TimeSheetSummaryModel>()
                .ID("gridSummary")
                .DataSource(d => d.Mvc()
                    .Controller("Timesheet")
                    .LoadAction("GetSummary")
                    .LoadParams(new { MonthTimeSheet = new JS("MonthTimeSheet") })
                //.Key("TongHopTheoNgayID")
                )
                .ShowBorders(true)
                .ShowRowLines(true)
                .ShowColumnLines(true)
                .ColumnAutoWidth(true)
                .ColumnHidingEnabled(true)
                .RowAlternationEnabled(true)
                .Columns(columns => {
                    columns.AddFor(m => m.Key).Caption(T["Tổng công"].Value).AllowSorting(false);
                    columns.AddFor(m => m.Value).Caption(T["Số lượng"].Value).Width(150).AllowSorting(false);
                })
                .OnContentReady("contentReady")
                .Paging(p => p.PageSize(100))
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 301 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Timesheet\Index.cshtml"
Write(Html.DevExtreme().Popup()
    .ID("popup")
    .ShowTitle(true)
    .Title("Giải trình công")
    .Visible(false)
    .DragEnabled(false)
    .CloseOnOutsideClick(true)
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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

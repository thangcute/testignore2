#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f134c9c563d13f9a6a3326e495e4aa21832f55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_Index), @"mvc.1.0.view", @"/Views/Training/Index.cshtml")]
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
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
using Humax.ESS.Models.Trainning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f134c9c563d13f9a6a3326e495e4aa21832f55", @"/Views/Training/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Training_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrainningOpenningModel>>
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
  
    ViewData["Title"] = T["Đào tạo"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73f134c9c563d13f9a6a3326e495e4aa21832f555377", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f134c9c563d13f9a6a3326e495e4aa21832f556491", async() => {
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

<style>
    .courses__body {
        max-width: 100%;
    }

    .courses__line,
    .courses__details {
        margin-bottom: 15px;
    }

    .courses__wrap .courses__line:last-child {
        margin-bottom: 0px;
    }

    .player__item {
        padding: 0px;
        border: unset;
        background: unset;
    }
</style>

<script>
    function OpenEvaluate(_id, _title = '', _approve = 0) {
        var __title = _title != '' ? _title : '");
#nullable restore
#line 37 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                          Write(T["Đánh giá khóa học"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        var __url = '/Training/Evaluate?id=' + _id;
        var __popup = 'popup';
        var __data = {
            id: _id,
            approve: _approve
        };
        var __width = 650;
        var __offset = 55;

        FormDetail(_id, __title, __url, __popup, __data, __width, __offset);
    }

    var Training = {
        Joinning: function () {
            $.ajax({
                url: '/Training/Joinning',
                dataType: 'html',
                type: 'GET',
                async: false,
                data: {
                },
                success: function (response, status, jqXHR) {
                    $('.courses__list[tab=""#joinning""]').append(response);
                },
                error: function (jqXHR, status, err) {
                    console.log(err);
                },
                complete: function (jqXHR, status) {
                }
            });
        },
        Finished: function () {
            $.ajax({
        ");
            WriteLiteral(@"        url: '/Training/Finished',
                dataType: 'html',
                type: 'GET',
                async: false,
                data: {
                },
                success: function (response, status, jqXHR) {
                    $('.courses__list[tab=""#finished""]').append(response);
                },
                error: function (jqXHR, status, err) {
                    console.log(err);
                },
                complete: function (jqXHR, status) {
                }
            });
        }
    };

    $(function () {
        $('.courses__link[tab=""tab_courses""]').click(function () {
            $('.courses__link[tab=""tab_courses""]').removeClass('active');
            $(this).addClass('active');
            //
            $('.courses__list[type=""tab_content""]').addClass('hidden');
            $('.courses__list[tab=""' + $(this).attr('href') + '""]').removeClass('hidden');
        });

        // get thong tin các khóa học khác
        Promise.a");
            WriteLiteral("ll([Training.Joinning(), Training.Finished()]).then(function (values) {\r\n            console.log(values);\r\n        });\r\n    });\r\n</script>\r\n\r\n<div class=\"sorting1\">\r\n    <div class=\"sorting1__row\">\r\n        <h1 class=\"sorting1__title title\">");
#nullable restore
#line 107 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                     Write(T["Đào tạo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div class=\"sorting1__options\">\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"courses__head\">\r\n");
            WriteLiteral("    <div class=\"courses__row\">\r\n");
            WriteLiteral("        <ul class=\"courses__menu\">\r\n            <a class=\"courses__link active\" tab=\"tab_courses\" href=\"#open\">");
#nullable restore
#line 149 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                                                      Write(T["Khóa học đang mở"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <a class=\"courses__link\" tab=\"tab_courses\" href=\"#joinning\">");
#nullable restore
#line 150 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                                                   Write(T["Khóa học đang tham gia"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <a class=\"courses__link\" tab=\"tab_courses\" href=\"#finished\">");
#nullable restore
#line 151 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                                                   Write(T["Khóa học đã hoàn thành"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </ul>\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"courses__body\">\r\n    <div class=\"courses__list\" type=\"tab_content\" tab=\"#open\">\r\n");
#nullable restore
#line 189 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
          
            if (Model != null && Model.Any())
            {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"courses__item\">\r\n                        <div class=\"courses__preview\"><img class=\"courses__pic\" src=\"img/courses-pic-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 9457, "\"", 9463, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"courses__wrap\">\r\n                            <div class=\"courses__info\">");
#nullable restore
#line 197 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                                  Write(item.TenKhoaHoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"courses__details\">\r\n                                <span class=\"courses__desc\">Địa điểm</span>\r\n                                <span class=\"courses__category\">");
#nullable restore
#line 200 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                                           Write(item.DiaDiemDaoTao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"courses__details\">\r\n                                <span class=\"courses__desc\">Số tháng cam kết:</span>\r\n                                <span class=\"courses__category\">");
#nullable restore
#line 204 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                                           Write(item.SoThangCamKet);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""courses__line"">
                                <div class=""courses__box"">
                                    <svg class=""icon icon-clock"">
                                        <use xlink:href=""/img/sprite.svg#icon-clock""></use>
                                    </svg><span>");
#nullable restore
#line 210 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                            Write(string.Format("{0}-{1}", (item.TuNgay.HasValue ? item.TuNgay.Value.ToString("dd/MM/yyyy") : "#"), (item.ToiNgay.HasValue ? item.ToiNgay.Value.ToString("dd/MM/yyyy") : "#")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"courses__box\">\r\n");
#nullable restore
#line 213 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                      
                                        if (item.IsBatBuocThamGia.GetValueOrDefault(false))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <svg class=""icon icon-check-circle"">
                                                <use xlink:href=""/img/sprite.svg#icon-check-circle""></use>
                                            </svg><span>Bắt buộc</span>
");
#nullable restore
#line 219 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>
                            <div class=""courses__line"">
                                <div class=""courses__box"">
                                    <button class=""player__btn btn btn_blue"">Đăng ký tham gia</button>
                                </div>
                                <div class=""courses__box"">
                                    <button class=""player__btn btn btn_brown"">Từ chối tham gia</button>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 233 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"courses__list hidden\" type=\"tab_content\" tab=\"#joinning\">\r\n    </div>\r\n\r\n    <div class=\"courses__list hidden\" type=\"tab_content\" tab=\"#finished\">\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 245 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\Index.cshtml"
Write(Html.DevExtreme().Popup()
    .ID("popup")
    //.Width(300)
    //.Height('auto')
    .ShowTitle(true)
    .Title("Đánh giá khóa học")
    .Visible(false)
    .DragEnabled(false)
    .CloseOnOutsideClick(true)
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TrainningOpenningModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

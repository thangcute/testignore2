#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6179d5d62c348772db11225323e393e0893c0078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training__Evaluate), @"mvc.1.0.view", @"/Views/Training/_Evaluate.cshtml")]
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
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
using Humax.ESS.Models.Trainning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6179d5d62c348772db11225323e393e0893c0078", @"/Views/Training/_Evaluate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Training__Evaluate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrainingEvaluateModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_FormDynamic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
  
    if (Model != null && Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"player__container\" style=\"padding: 0px;\">\r\n            <div class=\"player__control\">\r\n                <div class=\"player__nav\">\r\n");
#nullable restore
#line 14 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
                      
                        bool _tab_active = true;
                        foreach (var item in Model)
                        {
                            if (_tab_active)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"player__link active\" tab=\"tab_evaluate\"");
            BeginWriteAttribute("href", " href=\"", 662, "\"", 678, 2);
            WriteAttributeValue("", 669, "#", 669, 1, true);
#nullable restore
#line 20 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
WriteAttributeValue("", 670, item.Id, 670, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
                                                                                              Write(item.TenNoiDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 21 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"

                                _tab_active = false;
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"player__link\" tab=\"tab_evaluate\"");
            BeginWriteAttribute("href", " href=\"", 928, "\"", 944, 2);
            WriteAttributeValue("", 935, "#", 935, 1, true);
#nullable restore
#line 26 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
WriteAttributeValue("", 936, item.Id, 936, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
                                                                                       Write(item.TenNoiDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 27 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"player__list\">\r\n");
#nullable restore
#line 33 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
                  
                    _tab_active = true;
                    foreach (var item in Model)
                    {
                        if (_tab_active)
                        {
                            _tab_active = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"player__item js-player-item\" type=\"tab_content\"");
            BeginWriteAttribute("tab", " tab=\"", 1472, "\"", 1487, 2);
            WriteAttributeValue("", 1478, "#", 1478, 1, true);
#nullable restore
#line 40 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
WriteAttributeValue("", 1479, item.Id, 1479, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6179d5d62c348772db11225323e393e0893c00788414", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6179d5d62c348772db11225323e393e0893c00788708", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 42 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.TieuChiDanhGia;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 45 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"player__item js-player-item hidden\" type=\"tab_content\"");
            BeginWriteAttribute("tab", " tab=\"", 1882, "\"", 1897, 2);
            WriteAttributeValue("", 1888, "#", 1888, 1, true);
#nullable restore
#line 48 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
WriteAttributeValue("", 1889, item.Id, 1889, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6179d5d62c348772db11225323e393e0893c007812203", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6179d5d62c348772db11225323e393e0893c007812498", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 50 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.TieuChiDanhGia;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 53 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 58 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Training\_Evaluate.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(function () {
        $('.player__link[tab=""tab_evaluate""]').click(function () {
            $('.player__link[tab=""tab_evaluate""]').removeClass('active');
            $(this).addClass('active');
            //
            $('.player__item[type=""tab_content""]').addClass('hidden');
            $('.player__item[tab=""' + $(this).attr('href') + '""]').removeClass('hidden');
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TrainingEvaluateModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

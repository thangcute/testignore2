#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af4be93514ddc1415a0cc90010c7b90ec2e1ca15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Work_Kanban), @"mvc.1.0.view", @"/Views/Task/Work/Kanban.cshtml")]
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
#line 1 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4be93514ddc1415a0cc90010c7b90ec2e1ca15", @"/Views/Task/Work/Kanban.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Task_Work_Kanban : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/kanban/scrumboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/kanban/theme-checkbox-radio.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/jquery-ui/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/kanban/ie11fix/fn.fix-padStart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/kanban/kanban.board.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/400x168.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("scrumboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml"
  
    ViewBag.Module = "Tsk";
    ViewData["Title"] = T["Đào tạo"];

    string errorMessage = null;
    if (ViewData["ErrorMessage"] != null)
        errorMessage = ViewData["ErrorMessage"].ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <!-- BEGIN PAGE LEVEL PLUGINS/CUSTOM STYLES -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af4be93514ddc1415a0cc90010c7b90ec2e1ca157594", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af4be93514ddc1415a0cc90010c7b90ec2e1ca158859", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!-- END PAGE LEVEL PLUGINS/CUSTOM STYLES -->
    <style>
        .projects__container {
            margin-top: 15px !important;
        }

        .card,
        .scrumboard .card-done {
            border: none !important;
            border-radius: 4px !important;
            margin-bottom: 30px !important;
            box-shadow: 2px 5px 17px 0 rgb(31 45 61 / 10%) !important;
        }

        .card-done {
            position: relative !important;
            display: flex !important;
            flex-direction: column !important;
            min-width: 0 !important;
            word-wrap: break-word !important;
            background-color: #fff !important;
            background-clip: border-box !important;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af4be93514ddc1415a0cc90010c7b90ec2e1ca1511057", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- BEGIN PAGE LEVEL PLUGINS/CUSTOM SCRIPTS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af4be93514ddc1415a0cc90010c7b90ec2e1ca1512213", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af4be93514ddc1415a0cc90010c7b90ec2e1ca1513348", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- BEGIN PAGE LEVEL PLUGINS/CUSTOM SCRIPTS -->\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"sorting1\">\r\n    <div class=\"sorting1__row\">\r\n        <h1 class=\"sorting1__title title\">");
#nullable restore
#line 54 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml"
                                     Write(T["Quản lý công việc"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 55 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml"
         if (!string.IsNullOrEmpty(errorMessage))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"error-messsage\">");
#nullable restore
#line 57 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml"
                                   Write(errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 58 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""sorting1__options"">
            <div class=""sorting1__search js-sorting-search"">
                <a class=""group__btn btn btn_blue js-popup-open"" href=""#popup-details"" data-effect=""mfp-zoom-in"">
                    <i class=""icon dx-icon-plus""></i>");
#nullable restore
#line 62 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml"
                                                Write(T["Đăng ký"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </a>
            </div>
        </div>
    </div>
</div>

<div class=""content-block"">
    <div class=""player__container"">
        <div class=""player__control"">
            <div class=""player__nav"">
                <a class=""player__link active"" data-type=""tabs"" href=""javascript:void(0);"">Danh sách công việc</a>
            </div>

            <div class=""player__settings"">
                <a class=""player__link"" title=""List""");
            BeginWriteAttribute("href", " href=\"", 2700, "\"", 2739, 1);
#nullable restore
#line 77 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml"
WriteAttributeValue("", 2707, Url.Action("Index", "TaskWork"), 2707, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/img/table.svg\">\r\n                </a>\r\n                <a class=\"player__link\" title=\"Kanban\"");
            BeginWriteAttribute("href", " href=\"", 2867, "\"", 2907, 1);
#nullable restore
#line 80 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml"
WriteAttributeValue("", 2874, Url.Action("Kanban", "TaskWork"), 2874, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/img/dashboard.svg\">\r\n                </a>\r\n                <a class=\"player__link\" title=\"Grantt\"");
            BeginWriteAttribute("href", " href=\"", 3039, "\"", 3079, 1);
#nullable restore
#line 83 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Task\Work\Kanban.cshtml"
WriteAttributeValue("", 3046, Url.Action("Grantt", "TaskWork"), 3046, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <img src=""/img/sorting-3.svg"">
                </a>
            </div>

            <div id=""kanban"" data-type=""tabs-content"" class=""player__list tab-active"">
                <div class=""projects__container cell js-projects-container scrumboard"">
                    <!--Start-->
                    <div class=""task-list-section"">

                        <div data-section=""s-new"" data-status=""new"" class=""task-list-container"" data-connect=""sorting"">
                            <div class=""connect-sorting"">
                                <div class=""task-container-header"">
                                    <h6 class=""s-heading"" data-listTitle=""In Progress"">In Progress</h6>
                                </div>

                                <div class=""connect-sorting-content"" data-sortable=""true"">

                                    <div data-draggable=""true"" class=""card img-task""");
            BeginWriteAttribute("style", " style=\"", 4019, "\"", 4027, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card-body\">\r\n\r\n                                            <div class=\"task-content\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af4be93514ddc1415a0cc90010c7b90ec2e1ca1519403", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n\r\n                                            <div class=\"task-header\">\r\n                                                <div");
            BeginWriteAttribute("class", " class=\"", 4461, "\"", 4469, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <h4");
            BeginWriteAttribute("class", " class=\"", 4528, "\"", 4536, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-taskTitle=""Creating a new Portfolio on Dribble"">Creating a new Portfolio on Dribble</h4>
                                                </div>
                                            </div>

                                            <div class=""task-body"">

                                                <div class=""task-bottom"">
                                                    <div class=""tb-section-1"">
                                                        <span data-taskDate=""08 Aug 2019""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-calendar""><rect x=""3"" y=""4"" width=""18"" height=""18"" rx=""2"" ry=""2""></rect><line x1=""16"" y1=""2"" x2=""16"" y2=""6""></line><line x1=""8"" y1=""2"" x2=""8"" y2=""6""></line><line x1=""3"" y1=""10"" x2=""21"" y2=""10""></line></svg> 08 Aug, 2019</span>
                                                    </div>
          ");
            WriteLiteral(@"                                          <div class=""tb-section-2"">
                                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-edit-2 s-task-edit""><path d=""M17 3a2.828 2.828 0 1 1 4 4L7.5 20.5 2 22l1.5-5.5L17 3z""></path></svg>
                                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-trash-2 s-task-delete""><polyline points=""3 6 5 6 21 6""></polyline><path d=""M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2""></path><line x1=""10"" y1=""11"" x2=""10"" y2=""17""></line><line x1=""14"" y1=""11"" x2=""14"" y2=""17""></line></svg>
                                                    </div>
             ");
            WriteLiteral(@"                                   </div>

                                            </div>
                                        </div>
                                    </div>

                                    <div data-draggable=""true"" class=""card simple-title-task""");
            BeginWriteAttribute("style", " style=\"", 6869, "\"", 6877, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card-body\">\r\n\r\n                                            <div class=\"task-header\">\r\n                                                <div");
            BeginWriteAttribute("class", " class=\"", 7071, "\"", 7079, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <h4");
            BeginWriteAttribute("class", " class=\"", 7138, "\"", 7146, 0);
            EndWriteAttribute();
            WriteLiteral(" data-taskTitle=\"Singapore Team Meet\">Singapore Team Meet</h4>\r\n                                                </div>\r\n                                                <div");
            BeginWriteAttribute("class", " class=\"", 7319, "\"", 7327, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-edit-2 s-task-edit""><path d=""M17 3a2.828 2.828 0 1 1 4 4L7.5 20.5 2 22l1.5-5.5L17 3z""></path></svg>
                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-trash-2 s-task-delete""><polyline points=""3 6 5 6 21 6""></polyline><path d=""M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2""></path><line x1=""10"" y1=""11"" x2=""10"" y2=""17""></line><line x1=""14"" y1=""11"" x2=""14"" y2=""17""></line></svg>
                                                </div>
                                            </div>

                                      ");
            WriteLiteral(@"  </div>
                                    </div>
                                </div>

                                <div class=""add-s-task"">
                                    <a class=""addTask""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-plus-circle""><circle cx=""12"" cy=""12"" r=""10""></circle><line x1=""12"" y1=""8"" x2=""12"" y2=""16""></line><line x1=""8"" y1=""12"" x2=""16"" y2=""12""></line></svg> Add Task</a>
                                </div>

                            </div>
                        </div>

                        <div data-section=""s-in-progress"" data-status=""processing"" class=""task-list-container"" data-connect=""sorting"">
                            <div class=""connect-sorting"">
                                <div class=""task-container-header"">
                                    <h6 class=""s-heading"" data-listTitle=");
            WriteLiteral(@"""Complete"">Complete</h6>
                                </div>

                                <div class=""connect-sorting-content"" data-sortable=""true"">
                                    <div data-draggable=""true"" class=""card simple-title-task ui-sortable-handle""");
            BeginWriteAttribute("style", " style=\"", 9648, "\"", 9656, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card-body\">\r\n\r\n                                            <div class=\"task-header\">\r\n                                                <div");
            BeginWriteAttribute("class", " class=\"", 9850, "\"", 9858, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <h4");
            BeginWriteAttribute("class", " class=\"", 9917, "\"", 9925, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tasktitle=\"Dinner with Kelly Young\">Dinner with Kelly Young</h4>\r\n                                                </div>\r\n                                                <div");
            BeginWriteAttribute("class", " class=\"", 10106, "\"", 10114, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-edit-2 s-task-edit""><path d=""M17 3a2.828 2.828 0 1 1 4 4L7.5 20.5 2 22l1.5-5.5L17 3z""></path></svg>
                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-trash-2 s-task-delete""><polyline points=""3 6 5 6 21 6""></polyline><path d=""M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2""></path><line x1=""10"" y1=""11"" x2=""10"" y2=""17""></line><line x1=""14"" y1=""11"" x2=""14"" y2=""17""></line></svg>
                                                </div>
                                            </div>

                                      ");
            WriteLiteral("  </div>\r\n                                    </div>\r\n\r\n                                    <div data-draggable=\"true\" class=\"card task-text-progress\"");
            BeginWriteAttribute("style", " style=\"", 11289, "\"", 11297, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card-body\">\r\n\r\n                                            <div class=\"task-header\">\r\n\r\n                                                <div");
            BeginWriteAttribute("class", " class=\"", 11493, "\"", 11501, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <h4");
            BeginWriteAttribute("class", " class=\"", 11560, "\"", 11568, 0);
            EndWriteAttribute();
            WriteLiteral(" data-taskTitle=\"Launch New SEO Wordpress Theme \">Launch New SEO Wordpress Theme </h4>\r\n                                                </div>\r\n\r\n                                                <div");
            BeginWriteAttribute("class", " class=\"", 11767, "\"", 11775, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-edit-2 s-task-edit""><path d=""M17 3a2.828 2.828 0 1 1 4 4L7.5 20.5 2 22l1.5-5.5L17 3z""></path></svg>
                                                </div>

                                            </div>

                                            <div class=""task-body"">

                                                <div class=""task-content"">
                                                    <p");
            BeginWriteAttribute("class", " class=\"", 12449, "\"", 12457, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-taskText=""Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>

                                                    <div");
            BeginWriteAttribute("class", " class=\"", 12788, "\"", 12796, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <div class=""progress br-30"">
                                                            <div class=""progress-bar bg-success"" role=""progressbar"" data-progressState=""20"" style=""width: 20%"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                        </div>

                                                        <p class=""progress-count"">20%</p>

                                                    </div>
                                                </div>

                                                <div class=""task-bottom"">
                                                    <div class=""tb-section-1"">
                                                        <span data-taskDate=""08 Aug 2019""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""f");
            WriteLiteral(@"eather feather-calendar""><rect x=""3"" y=""4"" width=""18"" height=""18"" rx=""2"" ry=""2""></rect><line x1=""16"" y1=""2"" x2=""16"" y2=""6""></line><line x1=""8"" y1=""2"" x2=""8"" y2=""6""></line><line x1=""3"" y1=""10"" x2=""21"" y2=""10""></line></svg> 08 Aug, 2019</span>
                                                    </div>
                                                    <div class=""tb-section-2"">
                                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-trash-2 s-task-delete""><polyline points=""3 6 5 6 21 6""></polyline><path d=""M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2""></path><line x1=""10"" y1=""11"" x2=""10"" y2=""17""></line><line x1=""14"" y1=""11"" x2=""14"" y2=""17""></line></svg>
                                                    </div>
                                                </div>

   ");
            WriteLiteral(@"                                         </div>

                                        </div>
                                    </div>
                                </div>

                                <div class=""add-s-task"">
                                    <a class=""addTask""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-plus-circle""><circle cx=""12"" cy=""12"" r=""10""></circle><line x1=""12"" y1=""8"" x2=""12"" y2=""16""></line><line x1=""8"" y1=""12"" x2=""16"" y2=""12""></line></svg> Add Task</a>
                                </div>
                            </div>
                        </div>

                        <div data-section=""s-approved"" data-status=""done"" class=""task-list-container"" data-connect=""sorting"">
                            <div class=""connect-sorting"">
                                <div class=""task-container-heade");
            WriteLiteral(@"r"">
                                    <h6 class=""s-heading"" data-listTitle=""New"">New</h6>
                                </div>
                                <div class=""connect-sorting-content"" data-sortable=""true"">

                                </div>
                                <div class=""add-s-task"">
                                    <a class=""addTask""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-plus-circle""><circle cx=""12"" cy=""12"" r=""10""></circle><line x1=""12"" y1=""8"" x2=""12"" y2=""16""></line><line x1=""8"" y1=""12"" x2=""16"" y2=""12""></line></svg> Add Task</a>
                                </div>
                            </div>
                        </div>

                    </div>
                    <!--End-->
                </div>
            </div>
        </div>
    </div>
</div>");
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
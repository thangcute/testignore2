#pragma checksum "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\CustomEditors\UploadFileStore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e5072cfb4c9b302d193c822a7094330317f41d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomEditors_UploadFileStore), @"mvc.1.0.view", @"/Views/Shared/CustomEditors/UploadFileStore.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5072cfb4c9b302d193c822a7094330317f41d6", @"/Views/Shared/CustomEditors/UploadFileStore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841dbda6553abfc7fb88316e476a6202977d63e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_CustomEditors_UploadFileStore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    #fileuploader-container {
        border: 1px solid #d3d3d3;
        border-radius:5px;
    }
</style>
<script>
    function getFileUploaderInstance() {
        return $(""#file-uploader"").dxFileUploader(""instance"");
    }

    function fileUploader_valueChanged(e) {
        var files = e.value;
        if (files.length > 0) {
            $(""#selected-files .selected-item"").remove();

            $.each(files, function (i, file) {
                var $selectedItem = $(""<div />"").addClass(""selected-item"");
                $selectedItem.append(
                    $(""<span />"").html(""Name: "" + file.name + ""<br/>""),
                    $(""<span />"").html(""Size "" + file.size + "" bytes"" + ""<br/>""),
                    $(""<span />"").html(""Type "" + file.type + ""<br/>""),
                    $(""<span />"").html(""Last Modified Date: "" + file.lastModifiedDate)
                );
                $selectedItem.appendTo($(""#selected-files""));
            });
            $(""#selected-file");
            WriteLiteral("s\").show();\r\n        }\r\n        else\r\n            $(\"#selected-files\").hide();\r\n    }\r\n</script>\r\n<div id=\"fileuploader-container\">\r\n    ");
#nullable restore
#line 34 "D:\OOS sortware\OOS HUMAX ESS\Humax.ESS\Views\Shared\CustomEditors\UploadFileStore.cshtml"
Write(Html.DevExtreme().FileUploader()
    .ID("file-uploader")
    .Name("myFile")
    .Multiple(true)
    .Accept("*")
    .UploadMode(FileUploadMode.Instantly)
    .UploadUrl(Url.Action("Upload", "FileUploader"))
    .OnValueChanged("function(e){ fileUploader_valueChanged(e); }")
    .SelectButtonText("Chọn file")
    .LabelText("hoặc Kéo file thả vào đây")
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
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

#pragma checksum "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5596535abef7208301406a04cfff84b0524240cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Images_Index), @"mvc.1.0.view", @"/Views/Images/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Images/Index.cshtml", typeof(AspNetCore.Views_Images_Index))]
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
#line 1 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\_ViewImports.cshtml"
using CognitiveServicesDemo;

#line default
#line hidden
#line 2 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\_ViewImports.cshtml"
using CognitiveServicesDemo.Models;

#line default
#line hidden
#line 1 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
using System.IO;

#line default
#line hidden
#line 2 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
using CognitiveServicesDemo.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5596535abef7208301406a04cfff84b0524240cc", @"/Views/Images/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcbfbe9876edcc163eaab63fdc3870b328a284a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Images_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Images", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FileUpload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
  
    ViewData["Title"] = "Images";

#line default
#line hidden
            BeginContext(100, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(105, 17, false);
#line 6 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
            BeginContext(131, 460, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5596535abef7208301406a04cfff84b0524240cc5943", async() => {
                BeginContext(229, 355, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <div class=""col-md-10"">
            <p>Upload one or more files using this form:</p>
            <input type=""file"" name=""files"" multiple />
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-md-10"">
            <input type=""submit"" value=""Upload"" />
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(591, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
  
    var images = Directory
        .GetFiles("wwwroot\\uploads", "*.*", SearchOption.AllDirectories)
        .Select(f => System.IO.Path.GetFileName(f))
        .ToImageList();

    if (images != null)
    {
        var id = 0;

#line default
#line hidden
            BeginContext(833, 36, true);
            WriteLiteral("        <div class=\"imgContainer\">\r\n");
            EndContext();
#line 31 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
             foreach (var img in images)
            {

#line default
#line hidden
            BeginContext(926, 133, true);
            WriteLiteral("                <div class=\"imageSquare\">\r\n                    <div class=\"centered\">\r\n                        <img class=\"imgSquare\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1059, "\"", 1135, 1);
#line 35 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
WriteAttributeValue("", 1065, Url.Content(String.Format("~/uploads/{0}", img.ImageName.ToString())), 1065, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1136, 159, true);
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"centered\">\r\n                        <button type=\"button\" class=\"btn btn-info\" id=\"btnGetData\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1295, "\"", 1340, 5);
            WriteAttributeValue("", 1305, "$.openModal(\'", 1305, 13, true);
#line 38 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
WriteAttributeValue("", 1318, img.ImageName, 1318, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1332, "\',", 1332, 2, true);
#line 38 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
WriteAttributeValue(" ", 1334, id, 1335, 3, false);

#line default
#line hidden
            WriteAttributeValue("", 1338, ");", 1338, 2, true);
            EndWriteAttribute();
            BeginContext(1341, 72, true);
            WriteLiteral(">\r\n                            Get info <div class=\"spinner-border spin\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1413, "\"", 1426, 2);
            WriteAttributeValue("", 1418, "spin-", 1418, 5, true);
#line 39 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
WriteAttributeValue("", 1423, id, 1423, 3, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1427, 121, true);
            WriteLiteral(" role=\"status\"><span class=\"sr-only\">Loading...</span></div>\r\n                        </button>\r\n                        ");
            EndContext();
            BeginContext(1548, 257, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5596535abef7208301406a04cfff84b0524240cc11628", async() => {
                BeginContext(1603, 67, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"ImageName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1670, "\"", 1692, 1);
#line 42 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
WriteAttributeValue("", 1678, img.ImageName, 1678, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1693, 105, true);
                WriteLiteral(" />\r\n                            <button class=\"btn btn-danger\">Delete</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1805, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
            BeginContext(1878, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 47 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
                      
                        if (Model != null && Model.ImageName == img.ImageName)
                        {
                            

#line default
#line hidden
            BeginContext(2038, 12, false);
#line 50 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
                       Write(Model.Result);

#line default
#line hidden
            EndContext();
#line 50 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
                                         
                        }
                    

#line default
#line hidden
            BeginContext(2102, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 54 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
                id++;
            }

#line default
#line hidden
            BeginContext(2164, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 57 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2190, 1042, true);
            WriteLiteral(@"<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Cognitive Services Info</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""partialViewContent"">

                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<script>
    $(function () {
        $('.spin').hide();
        $.openModal = function (path, id) {
            $('#spin-' + id).show();
            ");
            WriteLiteral("var requestUrl = \'");
            EndContext();
            BeginContext(3233, 35, false);
#line 84 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Images\Index.cshtml"
                         Write(Url.Action("GetSomeData", "Images"));

#line default
#line hidden
            EndContext();
            BeginContext(3268, 557, true);
            WriteLiteral(@"?path=' + path;
            $.get(requestUrl)
                .done(function (responsedata) {
                    console.log(""success"");
                    $(""#partialViewContent"").html(responsedata);
                    $('#myModal').modal('show');
                })
                .fail(function (err) {
                    alert(""Error"");
                })
                .always(function () {
                    console.log(""finished"");
                    $('#spin-' + id).hide();
                });
        };
    });
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd4577b45e8162ef43742368dc31dcf39759730e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Speech_Index), @"mvc.1.0.view", @"/Views/Speech/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Speech/Index.cshtml", typeof(AspNetCore.Views_Speech_Index))]
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
#line 1 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
using System.IO;

#line default
#line hidden
#line 2 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
using CognitiveServicesDemo.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd4577b45e8162ef43742368dc31dcf39759730e", @"/Views/Speech/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcbfbe9876edcc163eaab63fdc3870b328a284a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Speech_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpeechViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Speech", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TextToSpeech", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
  
    ViewData["Title"] = "Speech";

#line default
#line hidden
            BeginContext(100, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(105, 17, false);
#line 6 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
            BeginContext(129, 741, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd4577b45e8162ef43742368dc31dcf39759730e5275", async() => {
                BeginContext(199, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(229, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 9 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
                BeginContext(261, 12, true);
                WriteLiteral("        <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 273, "\"", 306, 3);
                WriteAttributeValue("", 281, "alert", 281, 5, true);
                WriteAttributeValue(" ", 286, "alert-", 287, 7, true);
#line 11 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
WriteAttributeValue("", 293, Model.Status, 293, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(307, 28, true);
                WriteLiteral(" role=\"alert\">\r\n            ");
                EndContext();
                BeginContext(336, 22, false);
#line 12 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
       Write(Html.Raw(Model.Result));

#line default
#line hidden
                EndContext();
                BeginContext(358, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 14 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(383, 176, true);
                WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"exampleFormControlTextarea1\">Write a text here</label>\r\n        <textarea class=\"form-control\" id=\"Text\" name=\"Text\" rows=\"5\">");
                EndContext();
#line 17 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
                                                                       if (Model != null) { 

#line default
#line hidden
                BeginContext(582, 20, false);
#line 17 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
                                                                                       Write(Html.Raw(Model.Text));

#line default
#line hidden
                EndContext();
#line 17 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
                                                                                                                  }

#line default
#line hidden
                BeginContext(604, 63, true);
                WriteLiteral("</textarea>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(668, 81, false);
#line 20 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Speech\Index.cshtml"
   Write(Html.DropDownList("Language", (IEnumerable<SelectListItem>)ViewData["Languages"]));

#line default
#line hidden
                EndContext();
                BeginContext(749, 114, true);
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" value=\"Text to speech\" class=\"btn btn-info\" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(870, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpeechViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
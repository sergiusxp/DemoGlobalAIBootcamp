#pragma checksum "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e2397040c7e747ca14ea42c3d7e0f428ec50c16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Text_SentimentAnalysis), @"mvc.1.0.view", @"/Views/Text/SentimentAnalysis.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Text/SentimentAnalysis.cshtml", typeof(AspNetCore.Views_Text_SentimentAnalysis))]
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
#line 1 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml"
using System.IO;

#line default
#line hidden
#line 2 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml"
using CognitiveServicesDemo.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e2397040c7e747ca14ea42c3d7e0f428ec50c16", @"/Views/Text/SentimentAnalysis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcbfbe9876edcc163eaab63fdc3870b328a284a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Text_SentimentAnalysis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sentiment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml"
  
    ViewData["Title"] = "Sentiment Analysis";

#line default
#line hidden
            BeginContext(112, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(117, 17, false);
#line 6 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(134, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
            BeginContext(141, 587, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e2397040c7e747ca14ea42c3d7e0f428ec50c165390", async() => {
                BeginContext(206, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(234, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 9 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml"
     if (Model != null)
    {

#line default
#line hidden
                BeginContext(266, 68, true);
                WriteLiteral("        <div class=\"alert alert-success\" role=\"alert\">\r\n            ");
                EndContext();
                BeginContext(335, 22, false);
#line 12 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml"
       Write(Html.Raw(Model.Result));

#line default
#line hidden
                EndContext();
                BeginContext(357, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 14 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml"
    }

#line default
#line hidden
                BeginContext(382, 176, true);
                WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"exampleFormControlTextarea1\">Write a text here</label>\r\n        <textarea class=\"form-control\" id=\"Text\" name=\"Text\" rows=\"5\">");
                EndContext();
#line 17 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml"
                                                                       if (Model != null) { 

#line default
#line hidden
                BeginContext(581, 20, false);
#line 17 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml"
                                                                                       Write(Html.Raw(Model.Text));

#line default
#line hidden
                EndContext();
#line 17 "C:\Users\sergio.meloni\Desktop\Global AI\CognitiveServicesDemo\CognitiveServicesDemo\Views\Text\SentimentAnalysis.cshtml"
                                                                                                                  }

#line default
#line hidden
                BeginContext(603, 118, true);
                WriteLiteral("</textarea>\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" value=\"Analyze\" class=\"btn btn-info\" />\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
